namespace U8Xml;

[Token(Token = "0x200001C")]
public sealed class XmlObject : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000030")]
	private readonly XmlObjectCore _core; //Field offset: 0x10

	[Token(Token = "0x17000020")]
	public override XmlNode Root
	{
		[Address(RVA = "0x180D180", Offset = "0x180C380", Length = "0xB")]
		[CalledBy(Type = "Polytoria.Controllers.GameIO+<LoadFromSite>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Controllers.GameIO+<ModelFromSite>d__12", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "LoadFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Action`1<Boolean>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "LoadModelFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
		[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "LoadModelFromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Model")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(XmlObjectCore), Member = "get_Root", ReturnType = typeof(XmlNode))]
		[Token(Token = "0x6000083")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x180D130", Offset = "0x180C330", Length = "0x43")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000084")]
	internal XmlObject(in XmlObjectCore core) { }

	[Address(RVA = "0x180CFB0", Offset = "0x180C1B0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000087")]
	public override RawString AsRawString() { }

	[Address(RVA = "0x180D010", Offset = "0x180C210", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlObjectCore), Member = "Dispose", ReturnType = typeof(void))]
	[Token(Token = "0x6000086")]
	public override void Dispose() { }

	[Address(RVA = "0x180D070", Offset = "0x180C270", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlObjectCore), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000085")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x180D180", Offset = "0x180C380", Length = "0xB")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO+<LoadFromSite>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO+<ModelFromSite>d__12", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "LoadFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Action`1<Boolean>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "LoadModelFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "LoadModelFromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Model")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlObjectCore), Member = "get_Root", ReturnType = typeof(XmlNode))]
	[Token(Token = "0x6000083")]
	public override XmlNode get_Root() { }

	[Address(RVA = "0x180D0D0", Offset = "0x180C2D0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RawString), Member = "ToString", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[NullableContext(1)]
	[Token(Token = "0x6000088")]
	public virtual string ToString() { }

}

