namespace System.ComponentModel.Design.Serialization;

[AttributeUsage(1028, AllowMultiple = True, Inherited = True)]
[Obsolete("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  https://go.microsoft.com/fwlink/?linkid=14202")]
[Token(Token = "0x200019F")]
public sealed class RootDesignerSerializerAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000669")]
	private string _typeId; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400066A")]
	private readonly bool <Reloadable>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400066B")]
	private readonly string <SerializerTypeName>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400066C")]
	private readonly string <SerializerBaseTypeName>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x170001D3")]
	public string SerializerBaseTypeName
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60009E3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001D4")]
	public virtual object TypeId
	{
		[Address(RVA = "0x17A9060", Offset = "0x17A8260", Length = "0x9D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60009E4")]
		 get { } //Length: 157
	}

	[Address(RVA = "0x17A8FF0", Offset = "0x17A81F0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009E2")]
	public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E3")]
	public string get_SerializerBaseTypeName() { }

	[Address(RVA = "0x17A9060", Offset = "0x17A8260", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009E4")]
	public virtual object get_TypeId() { }

}

