namespace UnityEngine.UIElements;

[Token(Token = "0x2000456")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StyleComplexSelector : ISerializationCallbackReceiver
{
	[CompilerGenerated]
	[Token(Token = "0x2000458")]
	private sealed class <>c
	{
		[Token(Token = "0x4000E44")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000E45")]
		public static Func<StyleSelector, String> <>9__24_0; //Field offset: 0x8
		[Token(Token = "0x4000E46")]
		public static Predicate<StyleSelectorPart> <>9__27_0; //Field offset: 0x10

		[Address(RVA = "0x1B37410", Offset = "0x1B36610", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600207E")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600207F")]
		public <>c() { }

		[Address(RVA = "0x1B372E0", Offset = "0x1B364E0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002081")]
		internal bool <CalculateHashes>b__27_0(StyleSelectorPart p) { }

		[Address(RVA = "0x313D20", Offset = "0x312F20", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002080")]
		internal string <ToString>b__24_0(StyleSelector x) { }

	}

	[Token(Token = "0x2000457")]
	private struct PseudoStateData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E42")]
		public readonly PseudoStates state; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000E43")]
		public readonly bool negate; //Field offset: 0x4

		[Address(RVA = "0x880BE0", Offset = "0x87FDE0", Length = "0x7")]
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[Token(Token = "0x600207D")]
		public PseudoStateData(PseudoStates state, bool negate) { }

	}

	[Token(Token = "0x4000E40")]
	private static Dictionary<String, PseudoStateData> s_PseudoStates; //Field offset: 0x0
	[Token(Token = "0x4000E41")]
	private static List<StyleSelectorPart> m_HashList; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E38")]
	public Hashes ancestorHashes; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000E39")]
	private int m_Specificity; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E3A")]
	private StyleRule <rule>k__BackingField; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E3B")]
	private bool m_isSimple; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000E3C")]
	private StyleSelector[] m_Selectors; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000E3D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal int ruleIndex; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E3E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleComplexSelector nextInTable; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E3F")]
	internal int orderInStyleSheet; //Field offset: 0x50

	[Token(Token = "0x170008BC")]
	public bool isSimple
	{
		[Address(RVA = "0x1979D90", Offset = "0x1978F90", Length = "0x7")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002072")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170008BB")]
	public internal StyleRule rule
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002070")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002071")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170008BD")]
	public internal StyleSelector[] selectors
	{
		[Address(RVA = "0x19AA840", Offset = "0x19A9A40", Length = "0x7")]
		[CallerCount(Count = 36)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002073")]
		 get { } //Length: 7
		[Address(RVA = "0x1B281A0", Offset = "0x1B273A0", Length = "0x34")]
		[CalledBy(Type = typeof(UQueryBuilder`1), Member = "FinishSelector", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002074")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 52
	}

	[Token(Token = "0x170008BA")]
	public int specificity
	{
		[Address(RVA = "0xFE9830", Offset = "0xFE8A30", Length = "0x6")]
		[CallerCount(Count = 20)]
		[DeduplicatedMethod]
		[Token(Token = "0x600206F")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1B28110", Offset = "0x1B27310", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600207C")]
	private static StyleComplexSelector() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600207B")]
	public StyleComplexSelector() { }

	[Address(RVA = "0x1B271D0", Offset = "0x1B263D0", Length = "0x758")]
	[CalledBy(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.StyleComplexSelector+PseudoStateData>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PseudoStateData&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, UnityEngine.UIElements.StyleComplexSelector+PseudoStateData>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PseudoStateData)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002077")]
	internal void CachePseudoStateMasks(StyleSheet styleSheet) { }

	[Address(RVA = "0x1B27930", Offset = "0x1B26B30", Length = "0x5CC")]
	[CalledBy(Type = typeof(StyleSheet), Member = "SetupReferences", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Comparison`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Comparison`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSelectorPart>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.UIElements.StyleSelectorPart>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600207A")]
	internal void CalculateHashes() { }

	[Address(RVA = "0x1979D90", Offset = "0x1978F90", Length = "0x7")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002072")]
	public bool get_isSimple() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002070")]
	public StyleRule get_rule() { }

	[Address(RVA = "0x19AA840", Offset = "0x19A9A40", Length = "0x7")]
	[CallerCount(Count = 36)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002073")]
	public StyleSelector[] get_selectors() { }

	[Address(RVA = "0xFE9830", Offset = "0xFE8A30", Length = "0x6")]
	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	[Token(Token = "0x600206F")]
	public int get_specificity() { }

	[Address(RVA = "0x1B27F00", Offset = "0x1B27100", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002076")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002075")]
	public override void OnBeforeSerialize() { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002071")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_rule(StyleRule value) { }

	[Address(RVA = "0x1B281A0", Offset = "0x1B273A0", Length = "0x34")]
	[CalledBy(Type = typeof(UQueryBuilder`1), Member = "FinishSelector", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002074")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_selectors(StyleSelector[] value) { }

	[Address(RVA = "0x1B27F30", Offset = "0x1B27130", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002079")]
	private static int StyleSelectorPartCompare(StyleSelectorPart x, StyleSelectorPart y) { }

	[Address(RVA = "0x1B27F80", Offset = "0x1B27180", Length = "0x184")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002078")]
	public virtual string ToString() { }

}

