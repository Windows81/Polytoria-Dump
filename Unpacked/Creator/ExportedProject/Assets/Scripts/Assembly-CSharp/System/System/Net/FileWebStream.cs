namespace System.Net;

[Token(Token = "0x200026B")]
internal sealed class FileWebStream : FileStream, ICloseEx
{
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000A15")]
	private FileWebRequest m_request; //Field offset: 0x70

	[Address(RVA = "0x17F3AE0", Offset = "0x17F2CE0", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000F89")]
	public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	[Address(RVA = "0x17F3B80", Offset = "0x17F2D80", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000F8A")]
	public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	[Address(RVA = "0x17F3660", Offset = "0x17F2860", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileWebStream), Member = "CheckError", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000F8F")]
	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	[Address(RVA = "0x17F3710", Offset = "0x17F2910", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileWebStream), Member = "CheckError", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000F91")]
	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	[Address(RVA = "0x17F37C0", Offset = "0x17F29C0", Length = "0x99")]
	[CalledBy(Type = typeof(FileWebStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FileWebStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileWebStream), Member = "BeginRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FileWebStream), Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(FileWebStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(FileWebStream), Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(NetRes), Member = "GetWebStatusString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebExceptionStatus)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F93")]
	private void CheckError() { }

	[Address(RVA = "0x17F3860", Offset = "0x17F2A60", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileWebRequest), Member = "UnblockReader", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000F8B")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x17F38F0", Offset = "0x17F2AF0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileStream), Member = "EndRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(FileWebStream), Member = "CheckError", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000F90")]
	public virtual int EndRead(IAsyncResult ar) { }

	[Address(RVA = "0x17F3930", Offset = "0x17F2B30", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileStream), Member = "EndWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileWebStream), Member = "CheckError", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000F92")]
	public virtual void EndWrite(IAsyncResult ar) { }

	[Address(RVA = "0x17F3970", Offset = "0x17F2B70", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileWebStream), Member = "CheckError", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000F8D")]
	public virtual int Read(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x17F3A00", Offset = "0x17F2C00", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F8C")]
	private override void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	[Address(RVA = "0x17F3A50", Offset = "0x17F2C50", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileWebStream), Member = "CheckError", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileStream), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000F8E")]
	public virtual void Write(Byte[] buffer, int offset, int size) { }

}

