namespace System.ComponentModel;

[ComVisible(True)]
[Token(Token = "0x2000187")]
public abstract class MemberDescriptor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000628")]
	private string name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000629")]
	private AttributeCollection attributeCollection; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400062A")]
	private Attribute[] attributes; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400062B")]
	private Attribute[] originalAttributes; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400062C")]
	private bool attributesFiltered; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x400062D")]
	private bool attributesFilled; //Field offset: 0x31
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400062E")]
	private int metadataVersion; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400062F")]
	private object lockCookie; //Field offset: 0x38

	[Token(Token = "0x170001C3")]
	protected override Attribute[] AttributeArray
	{
		[Address(RVA = "0x17A21E0", Offset = "0x17A13E0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemberDescriptor), Member = "CheckAttributesValid", ReturnType = typeof(void))]
		[Calls(Type = typeof(MemberDescriptor), Member = "FilterAttributesIfNeeded", ReturnType = typeof(void))]
		[Token(Token = "0x600095E")]
		 get { } //Length: 36
	}

	[Token(Token = "0x170001C4")]
	public override AttributeCollection Attributes
	{
		[Address(RVA = "0x17A2210", Offset = "0x17A1410", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemberDescriptor), Member = "CheckAttributesValid", ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600095F")]
		 get { } //Length: 215
	}

	[Token(Token = "0x170001C5")]
	public override string Name
	{
		[Address(RVA = "0x17A22F0", Offset = "0x17A14F0", Length = "0x43")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000960")]
		 get { } //Length: 67
	}

	[Address(RVA = "0x17A1A70", Offset = "0x17A0C70", Length = "0xB9")]
	[CalledBy(Type = typeof(MemberDescriptor), Member = "get_AttributeArray", ReturnType = typeof(Attribute[]))]
	[CalledBy(Type = typeof(MemberDescriptor), Member = "get_Attributes", ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000961")]
	private void CheckAttributesValid() { }

	[Address(RVA = "0x17A1B30", Offset = "0x17A0D30", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Attribute[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000962")]
	protected override AttributeCollection CreateAttributeCollection() { }

	[Address(RVA = "0x17A1BA0", Offset = "0x17A0DA0", Length = "0x125")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000963")]
	protected override void FillAttributes(IList attributeList) { }

	[Address(RVA = "0x17A1CD0", Offset = "0x17A0ED0", Length = "0x507")]
	[CalledBy(Type = typeof(MemberDescriptor), Member = "get_AttributeArray", ReturnType = typeof(Attribute[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B080")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6000964")]
	private void FilterAttributesIfNeeded() { }

	[Address(RVA = "0x17A21E0", Offset = "0x17A13E0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemberDescriptor), Member = "CheckAttributesValid", ReturnType = typeof(void))]
	[Calls(Type = typeof(MemberDescriptor), Member = "FilterAttributesIfNeeded", ReturnType = typeof(void))]
	[Token(Token = "0x600095E")]
	protected override Attribute[] get_AttributeArray() { }

	[Address(RVA = "0x17A2210", Offset = "0x17A1410", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemberDescriptor), Member = "CheckAttributesValid", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600095F")]
	public override AttributeCollection get_Attributes() { }

	[Address(RVA = "0x17A22F0", Offset = "0x17A14F0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000960")]
	public override string get_Name() { }

}

