namespace System.Xml.Schema;

[Token(Token = "0x2000158")]
public abstract class XmlSchemaParticle : XmlSchemaAnnotated
{
	[Token(Token = "0x200015A")]
	private class EmptyParticle : XmlSchemaParticle
	{

		[Address(RVA = "0x16BAFD0", Offset = "0x16BA1D0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(XmlSchemaParticle), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000B77")]
		public EmptyParticle() { }

	}

	[Flags]
	[Token(Token = "0x2000159")]
	private enum Occurs
	{
		None = 0,
		Min = 1,
		Max = 2,
	}

	[Token(Token = "0x40005F9")]
	internal static readonly XmlSchemaParticle Empty; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005F6")]
	private decimal minOccurs; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005F7")]
	private decimal maxOccurs; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005F8")]
	private Occurs flags; //Field offset: 0x30

	[Token(Token = "0x1700032D")]
	[XmlIgnore]
	public decimal MaxOccurs
	{
		[Address(RVA = "0x16D9BB0", Offset = "0x16D8DB0", Length = "0x19A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Decimal), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Decimal))]
		[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000B74")]
		 set { } //Length: 410
	}

	[Token(Token = "0x1700032C")]
	[XmlIgnore]
	public decimal MinOccurs
	{
		[Address(RVA = "0x16D9D50", Offset = "0x16D8F50", Length = "0x13D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Decimal), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Decimal))]
		[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000B73")]
		 set { } //Length: 317
	}

	[Address(RVA = "0x16D9A80", Offset = "0x16D8C80", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XmlSchemaParticle), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000B76")]
	private static XmlSchemaParticle() { }

	[Address(RVA = "0x16D9B30", Offset = "0x16D8D30", Length = "0x78")]
	[CalledBy(Type = typeof(XmlSchemaAny), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CreateAnyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaContentProcessing)}, ReturnType = typeof(XmlSchemaComplexType))]
	[CalledBy(Type = typeof(XmlSchemaGroupBase), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EmptyParticle), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaParticle), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaSequence), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B75")]
	protected XmlSchemaParticle() { }

	[Address(RVA = "0x16D9BB0", Offset = "0x16D8DB0", Length = "0x19A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000B74")]
	public void set_MaxOccurs(decimal value) { }

	[Address(RVA = "0x16D9D50", Offset = "0x16D8F50", Length = "0x13D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Decimal), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000B73")]
	public void set_MinOccurs(decimal value) { }

}

