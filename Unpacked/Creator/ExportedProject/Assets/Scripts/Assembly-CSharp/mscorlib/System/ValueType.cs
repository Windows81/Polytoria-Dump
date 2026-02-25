namespace System;

[ComVisible(True)]
[Token(Token = "0x20001D7")]
public abstract class ValueType
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600105B")]
	protected ValueType() { }

	[Address(RVA = "0x151EFA0", Offset = "0x151E1A0", Length = "0x1C3")]
	[CalledBy(Type = typeof(Enum), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ValueType), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020AE60")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600105D")]
	internal static bool DefaultEquals(object o1, object o2) { }

	[Address(RVA = "0x14D8440", Offset = "0x14D7640", Length = "0x8")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(ValueType), Member = "DefaultEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x600105E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x151F170", Offset = "0x151E370", Length = "0x8E")]
	[CalledBy(Type = "TMPro.HighlightState", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.LowLevel.GlyphValueRecord", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.GlyphMetrics", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.GlyphRect", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.HighlightState", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.Offset", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.ColorBlock", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.TMP_Offset", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "TryInsert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue", typeof(InsertionBehavior)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "FindEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CustomAttributeData), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CustomAttributeNamedArgument), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ValueTuple`3), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.FilterFunction", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020B1B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001060")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x151F200", Offset = "0x151E400", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020AE60")]
	[Token(Token = "0x600105C")]
	private static bool InternalEquals(object o1, object o2, out Object[] fields) { }

	[Address(RVA = "0x151F210", Offset = "0x151E410", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020B1B0")]
	[Token(Token = "0x600105F")]
	internal static int InternalGetHashCode(object o, out Object[] fields) { }

	[Address(RVA = "0x151F220", Offset = "0x151E420", Length = "0x30")]
	[CalledBy(Type = typeof(Nullable`1), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ValueTuple`3), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ValueTuple`3), Member = "System.IValueTupleInternal.ToStringEnd", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CustomAttributeNamedArgument), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001061")]
	public virtual string ToString() { }

}

