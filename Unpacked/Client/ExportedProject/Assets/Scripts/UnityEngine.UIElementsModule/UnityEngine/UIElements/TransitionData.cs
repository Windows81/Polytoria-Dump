namespace UnityEngine.UIElements;

[Token(Token = "0x20003E3")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct TransitionData : IStyleDataGroup<TransitionData>, IEquatable<TransitionData>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D15")]
	public List<TimeValue> transitionDelay; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D16")]
	public List<TimeValue> transitionDuration; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D17")]
	public List<StylePropertyName> transitionProperty; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D18")]
	public List<EasingFunction> transitionTimingFunction; //Field offset: 0x18

	[Address(RVA = "0x1B1CB90", Offset = "0x1B1BD90", Length = "0x191")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.StylePropertyName>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001D92")]
	public override TransitionData Copy() { }

	[Address(RVA = "0x1B1CA20", Offset = "0x1B1BC20", Length = "0x16E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.TimeValue>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.StylePropertyName>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.EasingFunction>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001D93")]
	public override void CopyFrom(ref TransitionData other) { }

	[Address(RVA = "0x1B1CD30", Offset = "0x1B1BF30", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001D95")]
	public override bool Equals(TransitionData other) { }

	[Address(RVA = "0x1B1CD70", Offset = "0x1B1BF70", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001D96")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1B1CE30", Offset = "0x1B1C030", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6001D97")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B1CEF0", Offset = "0x1B1C0F0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001D94")]
	public static bool op_Equality(TransitionData lhs, TransitionData rhs) { }

}

