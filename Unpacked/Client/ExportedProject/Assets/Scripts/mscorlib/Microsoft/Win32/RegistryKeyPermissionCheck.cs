namespace Microsoft.Win32;

[Token(Token = "0x200007C")]
public enum RegistryKeyPermissionCheck
{
	Default = 0,
	ReadSubTree = 1,
	ReadWriteSubTree = 2,
}

