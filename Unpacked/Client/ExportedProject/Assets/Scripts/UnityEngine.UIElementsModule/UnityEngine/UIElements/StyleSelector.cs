namespace UnityEngine.UIElements;

[Token(Token = "0x200045B")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleSelector
{
	[CompilerGenerated]
	[Token(Token = "0x200045C")]
	private sealed class <>c
	{
		[Token(Token = "0x4000E54")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000E55")]
		public static Func<StyleSelectorPart, String> <>9__11_0; //Field offset: 0x8

		[Address(RVA = "0x1B373A0", Offset = "0x1B365A0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600208D")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600208E")]
		public <>c() { }

		[Address(RVA = "0x1B37300", Offset = "0x1B36500", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StyleSelectorPart), Member = "ToString", ReturnType = typeof(string))]
		[Token(Token = "0x600208F")]
		internal string <ToString>b__11_0(StyleSelectorPart p) { }

	}

	[Token(Token = "0x4000E51")]
	public const int InvalidPseudoStateMask = -1; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000E4F")]
	private StyleSelectorPart[] m_Parts; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000E50")]
	private StyleSelectorRelationship m_PreviousRelationship; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000E52")]
	internal int pseudoStateMask; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E53")]
	internal int negatedPseudoStateMask; //Field offset: 0x20

	[Token(Token = "0x170008C1")]
	public internal StyleSelectorPart[] parts
	{
		[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
		[CallerCount(Count = 196)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002087")]
		 get { } //Length: 7
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002088")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170008C2")]
	public internal StyleSelectorRelationship previousRelationship
	{
		[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002089")]
		 get { } //Length: 6
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600208A")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x1B288E0", Offset = "0x1B27AE0", Length = "0xF")]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "FinishCurrentSelector", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600208C")]
	public StyleSelector() { }

	[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
	[CallerCount(Count = 196)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002087")]
	public StyleSelectorPart[] get_parts() { }

	[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002089")]
	public StyleSelectorRelationship get_previousRelationship() { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002088")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_parts(StyleSelectorPart[] value) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600208A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_previousRelationship(StyleSelectorRelationship value) { }

	[Address(RVA = "0x1B28780", Offset = "0x1B27980", Length = "0x157")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Token(Token = "0x600208B")]
	public virtual string ToString() { }

}

