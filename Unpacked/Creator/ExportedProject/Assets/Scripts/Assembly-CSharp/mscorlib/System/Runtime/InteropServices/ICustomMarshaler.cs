namespace System.Runtime.InteropServices;

[Token(Token = "0x2000435")]
public interface ICustomMarshaler
{

	[Token(Token = "0x6001F70")]
	public void CleanUpManagedData(object ManagedObj) { }

	[Token(Token = "0x6001F6F")]
	public void CleanUpNativeData(IntPtr pNativeData) { }

	[Token(Token = "0x6001F71")]
	public int GetNativeDataSize() { }

	[Token(Token = "0x6001F6E")]
	public IntPtr MarshalManagedToNative(object ManagedObj) { }

	[Token(Token = "0x6001F6D")]
	public object MarshalNativeToManaged(IntPtr pNativeData) { }

}

