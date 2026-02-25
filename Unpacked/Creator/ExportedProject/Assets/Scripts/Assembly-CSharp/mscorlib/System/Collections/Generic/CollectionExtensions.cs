namespace System.Collections.Generic;

[Extension]
[Token(Token = "0x20005ED")]
public static class CollectionExtensions
{

	[Address(RVA = "0x686920", Offset = "0x685B20", Length = "0x13B")]
	[CalledBy(Type = typeof(LocalDataStoreMgr), Member = "GetNamedDataSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(LocalDataStoreSlot))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.CustomConvertersCollection", Member = "GetScriptToClrCustomConversion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DynValue", typeof(Type)}, ReturnType = "System.Func`2<DynValue, Object>")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.CustomConvertersCollection", Member = "GetClrToScriptCustomConversion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = "System.Func`3<Script, Object, DynValue>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6002B82")]
	public static TValue GetValueOrDefault(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key) { }

	[Address(RVA = "0x686A60", Offset = "0x685C60", Length = "0x118")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheet", Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheetUtility", Member = "GetEnumExportString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Enum)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheetUtility", Member = "ConvertCamelToDash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6002B83")]
	public static TValue GetValueOrDefault(IReadOnlyDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue) { }

	[Address(RVA = "0x686EF0", Offset = "0x6860F0", Length = "0x155")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.CustomConvertersCollection", Member = "SetScriptToClrCustomConversion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DataType", typeof(Type), "System.Func`2<DynValue, Object>", "System.Func`2<DynValue, Boolean>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.CustomConvertersCollection", Member = "SetClrToScriptCustomConversion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Func`3<Script, Object, DynValue>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.CustomConvertersCollection", Member = "SetClrToScriptCustomConversion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Func`2<Object, DynValue>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6002B84")]
	public static bool Remove(IDictionary<TKey, TValue> dictionary, TKey key, out TValue value) { }

}

