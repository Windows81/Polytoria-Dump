namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x20003A4")]
internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EC0")]
	private string _uri; //Field offset: 0x10

	[Token(Token = "0x17000341")]
	public override int ArgCount
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C07")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000342")]
	public override Object[] Args
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C08")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000349")]
	public override LogicalCallContext LogicalCallContext
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C10")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000343")]
	public override MethodBase MethodBase
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C09")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000344")]
	public override string MethodName
	{
		[Address(RVA = "0x137E600", Offset = "0x137D800", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C0A")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000345")]
	public override object MethodSignature
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C0B")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000346")]
	public override IDictionary Properties
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C0C")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000347")]
	public override string TypeName
	{
		[Address(RVA = "0x137E630", Offset = "0x137D830", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C0D")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000348")]
	public override string Uri
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C0E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x137E5B0", Offset = "0x137D7B0", Length = "0x4F")]
	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "ProcessMessageInDomain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(CADMethodCallMessage)}, ReturnType = "System.Runtime.Remoting.Channels.CrossAppDomainSink+ProcessMessageRes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001C06")]
	public ErrorMessage() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C07")]
	public override int get_ArgCount() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C08")]
	public override Object[] get_Args() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C10")]
	public override LogicalCallContext get_LogicalCallContext() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C09")]
	public override MethodBase get_MethodBase() { }

	[Address(RVA = "0x137E600", Offset = "0x137D800", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001C0A")]
	public override string get_MethodName() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C0B")]
	public override object get_MethodSignature() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C0C")]
	public override IDictionary get_Properties() { }

	[Address(RVA = "0x137E630", Offset = "0x137D830", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001C0D")]
	public override string get_TypeName() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C0E")]
	public override string get_Uri() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001C0F")]
	public override object GetArg(int arg_num) { }

}

