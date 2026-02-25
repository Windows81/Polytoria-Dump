namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000427")]
internal sealed class NameInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400115A")]
	internal string NIFullName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400115B")]
	internal long NIobjectId; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400115C")]
	internal long NIassemId; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400115D")]
	internal InternalPrimitiveTypeE NIprimitiveTypeEnum; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400115E")]
	internal Type NItype; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400115F")]
	internal bool NIisSealed; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4001160")]
	internal bool NIisArray; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4001161")]
	internal bool NIisArrayItem; //Field offset: 0x3A
	[FieldOffset(Offset = "0x3B")]
	[Token(Token = "0x4001162")]
	internal bool NItransmitTypeOnObject; //Field offset: 0x3B
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001163")]
	internal bool NItransmitTypeOnMember; //Field offset: 0x3C
	[FieldOffset(Offset = "0x3D")]
	[Token(Token = "0x4001164")]
	internal bool NIisParentTypeOnObject; //Field offset: 0x3D
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001165")]
	internal InternalArrayTypeE NIarrayEnum; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001166")]
	private bool NIsealedStatusChecked; //Field offset: 0x44

	[Token(Token = "0x170003E4")]
	public bool IsSealed
	{
		[Address(RVA = "0x13BF410", Offset = "0x13BE610", Length = "0x35")]
		[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Type), Member = "get_IsSealed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001F42")]
		 get { } //Length: 53
	}

	[Token(Token = "0x170003E5")]
	public string NIname
	{
		[Address(RVA = "0x13BF450", Offset = "0x13BE650", Length = "0x4B")]
		[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(int), typeof(String[]), typeof(Type[]), typeof(WriteObjectInfo[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteSingleArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int), typeof(Array)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteJaggedArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteRectangleArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001F43")]
		 get { } //Length: 75
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F44")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F40")]
	internal NameInfo() { }

	[Address(RVA = "0x13BF410", Offset = "0x13BE610", Length = "0x35")]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsSealed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001F42")]
	public bool get_IsSealed() { }

	[Address(RVA = "0x13BF450", Offset = "0x13BE650", Length = "0x4B")]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(int), typeof(String[]), typeof(Type[]), typeof(WriteObjectInfo[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteSingleArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int), typeof(Array)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteJaggedArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteRectangleArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(WriteObjectInfo), typeof(NameInfo), typeof(int), typeof(Int32[]), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001F43")]
	public string get_NIname() { }

	[Address(RVA = "0x13BF3B0", Offset = "0x13BE5B0", Length = "0x5A")]
	[CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NameInfo), typeof(NameInfo), typeof(object), typeof(WriteObjectInfo), typeof(NameInfo), typeof(WriteObjectInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(WriteObjectInfo), typeof(InternalPrimitiveTypeE), typeof(NameInfo)}, ReturnType = typeof(NameInfo))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WriteObjectInfo), typeof(NameInfo)}, ReturnType = typeof(NameInfo))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(NameInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001F41")]
	internal void Init() { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F44")]
	public void set_NIname(string value) { }

}

