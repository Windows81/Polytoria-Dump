namespace System.Xml;

[Token(Token = "0x20000A6")]
internal class XmlCachedStream : MemoryStream
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400040B")]
	private Uri uri; //Field offset: 0x50

	[Address(RVA = "0x16B74B0", Offset = "0x16B66B0", Length = "0x15A")]
	[CalledBy(Type = "System.Xml.XmlDownloadManager+<GetNonFileStreamAsync>d__5", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlDownloadManager), Member = "GetNonFileStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(ICredentials), typeof(IWebProxy), typeof(RequestCachePolicy)}, ReturnType = typeof(Stream))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(MemoryStream), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60007BC")]
	internal XmlCachedStream(Uri uri, Stream stream) { }

}

