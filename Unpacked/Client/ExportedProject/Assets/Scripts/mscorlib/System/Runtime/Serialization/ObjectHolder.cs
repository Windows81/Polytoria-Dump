namespace System.Runtime.Serialization;

[Token(Token = "0x20003DA")]
internal sealed class ObjectHolder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F3E")]
	private object m_object; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F3F")]
	internal long m_id; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F40")]
	private int m_missingElementsRemaining; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000F41")]
	private int m_missingDecendents; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F42")]
	internal SerializationInfo m_serInfo; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F43")]
	internal ISerializationSurrogate m_surrogate; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000F44")]
	internal FixupHolderList m_missingElements; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F45")]
	internal LongList m_dependentObjects; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F46")]
	internal ObjectHolder m_next; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000F47")]
	internal int m_flags; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000F48")]
	private bool m_markForFixupWhenAvailable; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000F49")]
	private ValueTypeFixupInfo m_valueFixup; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000F4A")]
	private TypeLoadExceptionHolder m_typeLoad; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000F4B")]
	private bool m_reachable; //Field offset: 0x68

	[Token(Token = "0x170003AF")]
	internal bool CanObjectValueChange
	{
		[Address(RVA = "0x138BAE0", Offset = "0x138ACE0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		[Token(Token = "0x6001D56")]
		internal get { } //Length: 25
	}

	[Token(Token = "0x170003AE")]
	internal bool CanSurrogatedObjectValueChange
	{
		[Address(RVA = "0x138BB00", Offset = "0x138AD00", Length = "0x85")]
		[CalledBy(Type = typeof(ObjectManager), Member = "GetCompletionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixupHolder), typeof(ObjectHolder&), typeof(Object&), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectManager), Member = "DoNewlyRegisteredObjectFixups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectManager), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(object))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001D55")]
		internal get { } //Length: 133
	}

	[Token(Token = "0x170003BB")]
	internal bool CompletelyFixed
	{
		[Address(RVA = "0x138BB90", Offset = "0x138AD90", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001D68")]
		internal get { } //Length: 30
	}

	[Token(Token = "0x170003BC")]
	internal long ContainerID
	{
		[Address(RVA = "0x138BBB0", Offset = "0x138ADB0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001D69")]
		internal get { } //Length: 19
	}

	[Token(Token = "0x170003B8")]
	internal LongList DependentObjects
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D63")]
		internal get { } //Length: 5
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D64")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170003B0")]
	internal int DirectlyDependentObjects
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D57")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170003AC")]
	internal bool HasISerializable
	{
		[Address(RVA = "0x138BBD0", Offset = "0x138ADD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001D53")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170003AD")]
	internal bool HasSurrogate
	{
		[Address(RVA = "0x138BBE0", Offset = "0x138ADE0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001D54")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170003A8")]
	internal bool IsIncompleteObjectReference
	{
		[Address(RVA = "0x138BBF0", Offset = "0x138ADF0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D4D")]
		internal get { } //Length: 7
		[Address(RVA = "0x138BC80", Offset = "0x138AE80", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001D4E")]
		internal set { } //Length: 25
	}

	[Token(Token = "0x170003B5")]
	internal object ObjectValue
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D5E")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003B2")]
	internal bool Reachable
	{
		[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D59")]
		internal get { } //Length: 5
		[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D5A")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170003A9")]
	internal bool RequiresDelayedFixup
	{
		[Address(RVA = "0x138BC00", Offset = "0x138AE00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001D4F")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170003B9")]
	internal bool RequiresSerInfoFixup
	{
		[Address(RVA = "0x138BC10", Offset = "0x138AE10", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001D65")]
		internal get { } //Length: 20
		[Address(RVA = "0x138BCA0", Offset = "0x138AEA0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001D66")]
		internal set { } //Length: 27
	}

	[Token(Token = "0x170003AA")]
	internal bool RequiresValueTypeFixup
	{
		[Address(RVA = "0x138BC30", Offset = "0x138AE30", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001D50")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170003B6")]
	internal SerializationInfo SerializationInfo
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D60")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D61")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170003B7")]
	internal ISerializationSurrogate Surrogate
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D62")]
		internal get { } //Length: 95
	}

	[Token(Token = "0x170003B1")]
	internal int TotalDependentObjects
	{
		[Address(RVA = "0x1312DD0", Offset = "0x1311FD0", Length = "0x7")]
		[CallerCount(Count = 141)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D58")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x170003B4")]
	internal TypeLoadExceptionHolder TypeLoadException
	{
		[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D5C")]
		internal get { } //Length: 5
		[Address(RVA = "0xB087D0", Offset = "0xB079D0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D5D")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170003B3")]
	internal bool TypeLoadExceptionReachable
	{
		[Address(RVA = "0x138BC40", Offset = "0x138AE40", Length = "0x9")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001D5B")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x170003BA")]
	internal ValueTypeFixupInfo ValueFixup
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D67")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170003AB")]
	internal bool ValueTypeFixupPerformed
	{
		[Address(RVA = "0x138BC50", Offset = "0x138AE50", Length = "0x29")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001D51")]
		internal get { } //Length: 41
		[Address(RVA = "0x138BCC0", Offset = "0x138AEC0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001D52")]
		internal set { } //Length: 12
	}

	[Address(RVA = "0x138B670", Offset = "0x138A870", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001D41")]
	internal ObjectHolder(long objID) { }

	[Address(RVA = "0x138B730", Offset = "0x138A930", Length = "0x28A")]
	[CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(long), typeof(MemberInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ValueTypeFixupInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(FieldInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectHolder), Member = "SetFlags", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001D42")]
	internal ObjectHolder(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, Int32[] arrayIndex) { }

	[Address(RVA = "0x138B9C0", Offset = "0x138ABC0", Length = "0x11F")]
	[CalledBy(Type = typeof(ObjectManager), Member = "RegisterString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long), typeof(SerializationInfo), typeof(long), typeof(MemberInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ValueTypeFixupInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(FieldInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001D43")]
	internal ObjectHolder(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, Int32[] arrayIndex) { }

	[Address(RVA = "0x138AEC0", Offset = "0x138A0C0", Length = "0x165")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001D49")]
	internal void AddDependency(long dependentObject) { }

	[Address(RVA = "0x138B030", Offset = "0x138A230", Length = "0x12E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjectManager), Member = "FindOrCreateObjectHolder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(ObjectHolder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001D47")]
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	[Address(RVA = "0x138B160", Offset = "0x138A360", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectManager), Member = "FindOrCreateObjectHolder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(ObjectHolder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D45")]
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	[Address(RVA = "0x138BAE0", Offset = "0x138ACE0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6001D56")]
	internal bool get_CanObjectValueChange() { }

	[Address(RVA = "0x138BB00", Offset = "0x138AD00", Length = "0x85")]
	[CalledBy(Type = typeof(ObjectManager), Member = "GetCompletionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixupHolder), typeof(ObjectHolder&), typeof(Object&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "DoNewlyRegisteredObjectFixups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001D55")]
	internal bool get_CanSurrogatedObjectValueChange() { }

	[Address(RVA = "0x138BB90", Offset = "0x138AD90", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001D68")]
	internal bool get_CompletelyFixed() { }

	[Address(RVA = "0x138BBB0", Offset = "0x138ADB0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001D69")]
	internal long get_ContainerID() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D63")]
	internal LongList get_DependentObjects() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D57")]
	internal int get_DirectlyDependentObjects() { }

	[Address(RVA = "0x138BBD0", Offset = "0x138ADD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001D53")]
	internal bool get_HasISerializable() { }

	[Address(RVA = "0x138BBE0", Offset = "0x138ADE0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001D54")]
	internal bool get_HasSurrogate() { }

	[Address(RVA = "0x138BBF0", Offset = "0x138ADF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D4D")]
	internal bool get_IsIncompleteObjectReference() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D5E")]
	internal object get_ObjectValue() { }

	[Address(RVA = "0x3BAA60", Offset = "0x3B9C60", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D59")]
	internal bool get_Reachable() { }

	[Address(RVA = "0x138BC00", Offset = "0x138AE00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001D4F")]
	internal bool get_RequiresDelayedFixup() { }

	[Address(RVA = "0x138BC10", Offset = "0x138AE10", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001D65")]
	internal bool get_RequiresSerInfoFixup() { }

	[Address(RVA = "0x138BC30", Offset = "0x138AE30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001D50")]
	internal bool get_RequiresValueTypeFixup() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D60")]
	internal SerializationInfo get_SerializationInfo() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D62")]
	internal ISerializationSurrogate get_Surrogate() { }

	[Address(RVA = "0x1312DD0", Offset = "0x1311FD0", Length = "0x7")]
	[CallerCount(Count = 141)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D58")]
	internal int get_TotalDependentObjects() { }

	[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D5C")]
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	[Address(RVA = "0x138BC40", Offset = "0x138AE40", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001D5B")]
	internal bool get_TypeLoadExceptionReachable() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D67")]
	internal ValueTypeFixupInfo get_ValueFixup() { }

	[Address(RVA = "0x138BC50", Offset = "0x138AE50", Length = "0x29")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001D51")]
	internal bool get_ValueTypeFixupPerformed() { }

	[Address(RVA = "0x138B1C0", Offset = "0x138A3C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001D44")]
	private void IncrementDescendentFixups(int amount) { }

	[Address(RVA = "0x138B1D0", Offset = "0x138A3D0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001D4B")]
	internal void MarkForCompletionWhenAvailable() { }

	[Address(RVA = "0x138B1E0", Offset = "0x138A3E0", Length = "0x74")]
	[CalledBy(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001D46")]
	internal void RemoveDependency(long id) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D64")]
	internal void set_DependentObjects(LongList value) { }

	[Address(RVA = "0x138BC80", Offset = "0x138AE80", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001D4E")]
	internal void set_IsIncompleteObjectReference(bool value) { }

	[Address(RVA = "0x3BAC60", Offset = "0x3B9E60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D5A")]
	internal void set_Reachable(bool value) { }

	[Address(RVA = "0x138BCA0", Offset = "0x138AEA0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001D66")]
	internal void set_RequiresSerInfoFixup(bool value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D61")]
	internal void set_SerializationInfo(SerializationInfo value) { }

	[Address(RVA = "0xB087D0", Offset = "0xB079D0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D5D")]
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	[Address(RVA = "0x138BCC0", Offset = "0x138AEC0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001D52")]
	internal void set_ValueTypeFixupPerformed(bool value) { }

	[Address(RVA = "0x138B260", Offset = "0x138A460", Length = "0x8C")]
	[CalledBy(Type = typeof(ObjectHolder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(ISerializationSurrogate), typeof(long), typeof(FieldInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectHolder), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationInfo), typeof(ISerializationSurrogate), typeof(long), typeof(FieldInfo), typeof(Int32[]), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Token(Token = "0x6001D4C")]
	internal void SetFlags() { }

	[Address(RVA = "0x138B2F0", Offset = "0x138A4F0", Length = "0x129")]
	[CalledBy(Type = typeof(ObjectManager), Member = "FixupSpecialObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "ResolveObjectReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectHolder), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationInfo), typeof(ISerializationSurrogate), typeof(long), typeof(FieldInfo), typeof(Int32[]), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001D5F")]
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	[Address(RVA = "0x138B420", Offset = "0x138A620", Length = "0x1E1")]
	[CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(long), typeof(MemberInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectHolder), Member = "SetObjectValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValueTypeFixupInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(FieldInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectHolder), Member = "SetFlags", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectManager), Member = "FindOrCreateObjectHolder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(ObjectHolder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001D4A")]
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, Int32[] arrayIndex, ObjectManager manager) { }

	[Address(RVA = "0x138B610", Offset = "0x138A810", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectManager), Member = "FindOrCreateObjectHolder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(ObjectHolder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D48")]
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

}

