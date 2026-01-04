function QRBitBuffer() {
	this.buffer = [];
	this.length = 0;
}

QRBitBuffer.prototype = {

	get : function(index) {
		var bufIndex = Math.floor(index / 8);
		return ( (this.buffer[bufIndex] >>> (7 - index % 8) ) & 1) == 1;
	},
	
	put : function(num, length) {
		for (var i = 0; i < length; i++) {
			this.putBit( ( (num >>> (length - i - 1) ) & 1) == 1);
		}
	},
	
	getLengthInBits : function() {
		return this.length;
	},
	
	putBit : function(bit) {
	
		var bufIndex = Math.floor(this.length / 8);
		if (this.buffer.length <= bufIndex) {
			this.buffer.push(0);
		}
	
		if (bit) {
			this.buffer[bufIndex] |= (0x80 >>> (this.length % 8) );
		}
	
		this.length++;
	}
};

module.exports = QRBitBuffer;

// SIG // Begin signature block
// SIG // MIIoTAYJKoZIhvcNAQcCoIIoPTCCKDkCAQExDzANBglg
// SIG // hkgBZQMEAgEFADB3BgorBgEEAYI3AgEEoGkwZzAyBgor
// SIG // BgEEAYI3AgEeMCQCAQEEEBDgyQbOONQRoqMAEEvTUJAC
// SIG // AQACAQACAQACAQACAQAwMTANBglghkgBZQMEAgEFAAQg
// SIG // SsKJZUR15yxboY62fMPeR0JirtkjLqV8wx80n4l+C+yg
// SIG // gg2aMIIGGDCCBACgAwIBAgITMwAAA4MUYnEL35umPQAA
// SIG // AAADgzANBgkqhkiG9w0BAQsFADB+MQswCQYDVQQGEwJV
// SIG // UzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMH
// SIG // UmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBv
// SIG // cmF0aW9uMSgwJgYDVQQDEx9NaWNyb3NvZnQgQ29kZSBT
// SIG // aWduaW5nIFBDQSAyMDExMB4XDTIzMDcxMzIzNDUzNloX
// SIG // DTI0MDkxNTIzNDUzNlowgYgxCzAJBgNVBAYTAlVTMRMw
// SIG // EQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRt
// SIG // b25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRp
// SIG // b24xMjAwBgNVBAMTKU1pY3Jvc29mdCAzcmQgUGFydHkg
// SIG // QXBwbGljYXRpb24gQ29tcG9uZW50MIIBIjANBgkqhkiG
// SIG // 9w0BAQEFAAOCAQ8AMIIBCgKCAQEAlZ6RXxi6ssQbUoLu
// SIG // wsUg8Lzx5c2UB0kc6aIwqPLgFQAHd8Fujs2eO7JzXVxA
// SIG // 1yizqWqcy/7OQ0BytzPoM0/Dos4MCCt8Vofm41J7qoJl
// SIG // I1vRt3RH0+n1edFpKi+XbOdDqqZBPjx/fBLFa4HL5UD3
// SIG // u8adFOmz/YuCgHsv8q5oyzgtiH9cRamcUEBldYeb1jzo
// SIG // giSktqGeOO6bBVCq0Y2pOCSEOpAqRHZWuRoZrBnR9Dxb
// SIG // +54fqFuM9OaHQAt025PPApw4G2yWSerss9TEOVJ7YJ9F
// SIG // 3QnkBGwbHIqREw+zUQtdEI9kAai6NiD8U9tS/3QufZz7
// SIG // DI2Pnw3pnwQOKRUOkwIDAQABo4IBgjCCAX4wHwYDVR0l
// SIG // BBgwFgYKKwYBBAGCN0wRAQYIKwYBBQUHAwMwHQYDVR0O
// SIG // BBYEFLbqIlKYyBFhlR+UbIclG3Vb31x0MFQGA1UdEQRN
// SIG // MEukSTBHMS0wKwYDVQQLEyRNaWNyb