namespace UnityEngine.Scripting.APIUpdating;

[Token(Token = "0x20001DF")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct MovedFromAttributeData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400067A")]
	public string className; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400067B")]
	public string nameSpace; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400067C")]
	public string assembly; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400067D")]
	public bool classHasChanged; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x400067E")]
	public bool nameSpaceHasChanged; //Field offset: 0x19
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x400067F")]
	public bool assemblyHasChanged; //Field offset: 0x1A
	[FieldOffset(Offset = "0x1B")]
	[Token(Token = "0x4000680")]
	public bool autoUdpateAPI; //Field offset: 0x1B

	[Address(RVA = "0x1985580", Offset = "0x1984780", Length = "0x86")]
	[CalledBy(Type = typeof(MovedFromAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C8B")]
	public void Set(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null) { }

}

