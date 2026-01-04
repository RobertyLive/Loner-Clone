#pragma classflags("forceupdate")
#pragma namespace("\\\\.\\root\\WMI")
//
// WPP Generated File
// PDB:  z:\ntdmidev.obj.x86fre\base\pnp\drvinst\objfre\i386\DrvInst.pdb
// PDB:  Last Updated :2006-3-31:10:16:6:641 (UTC) [binplace]
//

//ModuleName = PlugPlay	 (Init called in Function wmain)
[Dynamic,
 Description("PnP Core Device Install Trace"),
 guid("{a676b545-4cfb-4306-a067-502d9a0f2220}"),
 locale("MS\\0x409")]
class PlugPlay : EventTrace
{
    [Description ("Enable Flags"),
        ValueDescriptions{
             "PNP_ERROR_LEVEL Flag",
             "PNP_WARNING_LEVEL Flag",
             "PNP_