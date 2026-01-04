ptableVolume.DeviceID
        #######

        $WmiVolumeFilter = "UniqueID = '$($Win32EncryptableVolume.DeviceID.Replace("\", "\\"))'"
        $MsftVolume =  Get-CimInstance MSFT_Volume -NameSpace 'Root\Microsoft\Windows\Storage' -Filter $WmiVolumeFilter
        if (!$MsftVolume)
        {
            $ExceptionForHr = Get-ExceptionForHrInternal -HrUInt32 $E_NOTFOUND
            $ErrorMessage = [string]::Format($stringTable.ErrorVolumeNotFound, $Win32EncryptableVolume.DeviceId)
            Write-Error -Exception $ExceptionForHr -Message $ErrorMessage

            Write-Debug "Filter: $WmiVolumeFilter"
            return
        }

        #
        # This matches WMI .Net's $Win32EncryptableVolume.__SERVER. 
        # MI .Net exposes $Win32EncryptableVolume.CimSystemProperties.ServerName as "localhost"
        #
        $ComputerName = $env:computername 

        #
        # Overwrite the passed in $MountPoint parameter with the the info from Win32_EncryptableVolume
        #
        if ($Win32EncryptableVolume.DriveLetter)
        {
            $MountPoint = $Win32EncryptableVolume.DriveLetter
        }
        else
        {
            $MountPoint = $Win32EncryptableVolume.DeviceID
        }

        #######
        # Get LockStatus. Win32_EncryptableVolume::GetLockStatus
        #######

        $LockStatusResult = Invoke-CimMethod -InputObject $Win32EncryptableVolume -MethodName GetLockStatus
        if ($LockStatusResult.ReturnValue -ne 0)
        {
            $ExceptionForHr = Get-ExceptionForHrInternal -HrUInt32 $LockStatusResult.ReturnValue
            Write-Error -Exception $ExceptionForHr
            return
        }
        $LockStatus = $LockStatusResult.LockStatus

        Write-Debug "ComputerName: $ComputerName. MountPoint: $MountPoint. LockStatus: $LockStatus"
        
        #######
        # Get EncryptionMethod. Win32_EncryptableVolume::GetEncryptionMethod
        #######

        $EncryptionMethodResult = Invoke-CimMethod -InputObject $Win32EncryptableVolume -MethodName GetEncryptionMethod
        if ($EncryptionMethodResult.ReturnValue -ne 0)
        {
            $ExceptionForHr = Get-ExceptionForHrInternal -HrUInt32 $EncryptionMethodResult.ReturnValue
            Write-Error -Exception $ExceptionForHr
            return
        }
        $EncryptionMethod = $EncryptionMethodResult.EncryptionMethod

        Write-Debug "EncryptionMethod: $EncryptionMethod"

        #######
        # Get EncryptionMethodFlags. Win32_EncryptableVolume::GetEncryptionMethodFlags
        #######

        $EncryptionMethodFlags = $EncryptionMethodResult.EncryptionMethodFlags

        Write-Debug "EncryptionMethodFlags: $EncryptionMethodFlags"

        #######
        # AutoUnlock. Win32_EncryptableVolume::IsAutoUnlockEnabled
        # This will determine if autounlock is enabled for the volume and what the
        # protector id is. This is relevant only for data volumes.
        # Failure is ok. It means the setting does not apply to this volume.
        #######

        $AutoUnlockEnabledResult = Invoke-CimMethod -InputObject $Win32EncryptableVolume -MethodName IsAutoUnlo