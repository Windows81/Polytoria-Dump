namespace System.Net;

[Token(Token = "0x2000248")]
internal class BufferOffsetSize
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000970")]
	internal Byte[] Buffer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000971")]
	internal int Offset; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000972")]
	internal int Size; //Field offset: 0x1C

	[Address(RVA = "0x17CD530", Offset = "0x17CC730", Length = "0xBA")]
	[CalledBy(Type = "System.Net.HttpWebRequest+<<GetRewriteHandler>b__271_0>d", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteRequestAsync>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebRequestStream), Member = "GetWriteBuffer", ReturnType = typeof(BufferOffsetSize))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<InitReadAsync>d__52", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EB0")]
	internal BufferOffsetSize(Byte[] buffer, int offset, int size, bool copyBuffer) { }

	[Address(RVA = "0x17CD470", Offset = "0x17CC670", Length = "0xB9")]
	[CalledBy(Type = "System.Net.WebResponseStream+<InitReadAsync>d__52", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000EB1")]
	internal BufferOffsetSize(Byte[] buffer, bool copyBuffer) { }

}

