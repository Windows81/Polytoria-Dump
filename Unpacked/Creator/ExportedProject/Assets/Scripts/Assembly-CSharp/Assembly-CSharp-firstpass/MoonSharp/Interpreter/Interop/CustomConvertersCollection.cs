namespace MoonSharp.Interpreter.Interop;

[Token(Token = "0x20000C9")]
public class CustomConvertersCollection
{
	[CompilerGenerated]
	[Token(Token = "0x20000CA")]
	private sealed class <>c__DisplayClass10_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400038B")]
		public Func<T, DynValue> converter; //Field offset: 0x0

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000880")]
		public <>c__DisplayClass10_0`1() { }

		[Address(RVA = "0x7FD550", Offset = "0x7FC750", Length = "0xF1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EDA30")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000881")]
		internal DynValue <SetClrToScriptCustomConversion>b__0(object o) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000CB")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400038C")]
		public Func<Script, T, DynValue> converter; //Field offset: 0x0

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000882")]
		public <>c__DisplayClass7_0`1() { }

		[Address(RVA = "0x8014D0", Offset = "0x8006D0", Length = "0x103")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EDA30")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000883")]
		internal DynValue <SetClrToScriptCustomConversion>b__0(Script s, object o) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000CC")]
	private sealed class <>c__DisplayClass9_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400038D")]
		public Func<Object, DynValue> converter; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000884")]
		public <>c__DisplayClass9_0() { }

		[Address(RVA = "0x32E810", Offset = "0x32DA10", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000885")]
		internal DynValue <SetClrToScriptCustomConversion>b__0(Script s, object o) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000388")]
	private ConcurrentDictionary<Type, Func`2<DynValue, Object>>[] m_Script2Clr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000389")]
	private ConcurrentDictionary<Type, Func`3<Script, Object, DynValue>> m_Clr2Script; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400038A")]
	private ConcurrentDictionary<Type, Func`2<DynValue, Boolean>> m_conversionPredicates; //Field offset: 0x20

	[Address(RVA = "0x31AAF0", Offset = "0x319CF0", Length = "0x1C9")]
	[CalledBy(Type = typeof(Script), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptGlobalOptions), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000877")]
	internal CustomConvertersCollection() { }

	[Address(RVA = "0x31A4B0", Offset = "0x3196B0", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600087F")]
	public void Clear() { }

	[Address(RVA = "0x31A570", Offset = "0x319770", Length = "0x49")]
	[CalledBy(Type = typeof(ClrToScriptConversions), Member = "TryObjectToSimpleDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CollectionExtensions), Member = "GetValueOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyDictionary`2<TKey, TValue>", "TKey"}, ReturnType = "TValue")]
	[Token(Token = "0x600087C")]
	public Func<Script, Object, DynValue> GetClrToScriptCustomConversion(Type clrDataType) { }

	[Address(RVA = "0x31A5C0", Offset = "0x3197C0", Length = "0xF2")]
	[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ScriptToClrConversions), Member = "DynValueToObjectOfTypeWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Type), typeof(bool)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CollectionExtensions), Member = "GetValueOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IReadOnlyDictionary`2<TKey, TValue>", "TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000879")]
	public Func<DynValue, Object> GetScriptToClrCustomConversion(DynValue scriptValue, Type clrDataType) { }

	[Address(RVA = "0x31A810", Offset = "0x319A10", Length = "0xC2")]
	[CalledBy(Type = typeof(CustomConvertersCollection), Member = "SetClrToScriptCustomConversion", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`3<Script, T, DynValue>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionExtensions), Member = "Remove", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<TKey, TValue>", "TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600087A")]
	public void SetClrToScriptCustomConversion(Type clrDataType, Func<Script, Object, DynValue> converter = null) { }

	[Address(RVA = "0x68EF80", Offset = "0x68E180", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CustomConvertersCollection), Member = "SetClrToScriptCustomConversion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Func`3<MoonSharp.Interpreter.Script, System.Object, MoonSharp.Interpreter.DynValue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600087B")]
	public void SetClrToScriptCustomConversion(Func<Script, T, DynValue> converter = null) { }

	[Address(RVA = "0x31A6C0", Offset = "0x3198C0", Length = "0x14E")]
	[CalledBy(Type = typeof(CustomConvertersCollection), Member = "SetClrToScriptCustomConversion", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<T, DynValue>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionExtensions), Member = "Remove", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<TKey, TValue>", "TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Obsolete("This method is deprecated. Use the overloads accepting functions with a Script argument.")]
	[Token(Token = "0x600087D")]
	public void SetClrToScriptCustomConversion(Type clrDataType, Func<Object, DynValue> converter = null) { }

	[Address(RVA = "0x68EE60", Offset = "0x68E060", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CustomConvertersCollection), Member = "SetClrToScriptCustomConversion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(System.Func`2<System.Object, MoonSharp.Interpreter.DynValue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Obsolete("This method is deprecated. Use the overloads accepting functions with a Script argument.")]
	[Token(Token = "0x600087E")]
	public void SetClrToScriptCustomConversion(Func<T, DynValue> converter = null) { }

	[Address(RVA = "0x31A8E0", Offset = "0x319AE0", Length = "0x208")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CollectionExtensions), Member = "Remove", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<TKey, TValue>", "TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000878")]
	public void SetScriptToClrCustomConversion(DataType scriptDataType, Type clrDataType, Func<DynValue, Object> converter = null, Func<DynValue, Boolean> canConvert = null) { }

}

