namespace System.Runtime.Serialization;

[Token(Token = "0x20003E9")]
internal sealed class SerializationFieldInfo : FieldInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F64")]
	private RuntimeFieldInfo m_field; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F65")]
	private string m_serializationName; //Field offset: 0x18

	[Token(Token = "0x170003CE")]
	public virtual FieldAttributes Attributes
	{
		[Address(RVA = "0x1393560", Offset = "0x1392760", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DA5")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170003C9")]
	public virtual Type DeclaringType
	{
		[Address(RVA = "0x1393590", Offset = "0x1392790", Length = "0x2A")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D99")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170003CD")]
	public virtual RuntimeFieldHandle FieldHandle
	{
		[Address(RVA = "0x13935C0", Offset = "0x13927C0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001DA4")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170003CC")]
	internal RuntimeFieldInfo FieldInfo
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DA3")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003CB")]
	public virtual Type FieldType
	{
		[Address(RVA = "0x13935F0", Offset = "0x13927F0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D9E")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170003C7")]
	public virtual int MetadataToken
	{
		[Address(RVA = "0x1393620", Offset = "0x1392820", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D96")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170003C6")]
	public virtual Module Module
	{
		[Address(RVA = "0x1393650", Offset = "0x1392850", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D95")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170003C8")]
	public virtual string Name
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D98")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003CA")]
	public virtual Type ReflectedType
	{
		[Address(RVA = "0x1393680", Offset = "0x1392880", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D9A")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x13934B0", Offset = "0x13926B0", Length = "0xA3")]
	[CalledBy(Type = typeof(FormatterServices), Member = "InternalGetSerializableMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(MemberInfo[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001D97")]
	internal SerializationFieldInfo(RuntimeFieldInfo field, string namePrefix) { }

	[Address(RVA = "0x1393560", Offset = "0x1392760", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DA5")]
	public virtual FieldAttributes get_Attributes() { }

	[Address(RVA = "0x1393590", Offset = "0x1392790", Length = "0x2A")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D99")]
	public virtual Type get_DeclaringType() { }

	[Address(RVA = "0x13935C0", Offset = "0x13927C0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001DA4")]
	public virtual RuntimeFieldHandle get_FieldHandle() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DA3")]
	internal RuntimeFieldInfo get_FieldInfo() { }

	[Address(RVA = "0x13935F0", Offset = "0x13927F0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D9E")]
	public virtual Type get_FieldType() { }

	[Address(RVA = "0x1393620", Offset = "0x1392820", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D96")]
	public virtual int get_MetadataToken() { }

	[Address(RVA = "0x1393650", Offset = "0x1392850", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D95")]
	public virtual Module get_Module() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D98")]
	public virtual string get_Name() { }

	[Address(RVA = "0x1393680", Offset = "0x1392880", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D9A")]
	public virtual Type get_ReflectedType() { }

	[Address(RVA = "0x1393200", Offset = "0x1392400", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001D9B")]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1393230", Offset = "0x1392430", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001D9C")]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1393260", Offset = "0x1392460", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001D9F")]
	public virtual object GetValue(object obj) { }

	[Address(RVA = "0x1393290", Offset = "0x1392490", Length = "0xA5")]
	[CalledBy(Type = typeof(FormatterServices), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(MemberInfo[])}, ReturnType = typeof(Object[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001DA0")]
	internal object InternalGetValue(object obj) { }

	[Address(RVA = "0x1393340", Offset = "0x1392540", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001DA2")]
	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	[Address(RVA = "0x1393440", Offset = "0x1392640", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001D9D")]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1393470", Offset = "0x1392670", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001DA1")]
	public virtual void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

