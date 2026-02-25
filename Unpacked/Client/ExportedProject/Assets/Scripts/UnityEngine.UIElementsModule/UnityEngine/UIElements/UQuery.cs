namespace UnityEngine.UIElements;

[Token(Token = "0x20004A2")]
public static class UQuery
{
	[Token(Token = "0x20004A8")]
	public class FirstQueryMatcher : SingleQueryMatcher
	{
		[Token(Token = "0x4000FBD")]
		public static readonly FirstQueryMatcher Instance; //Field offset: 0x0

		[Address(RVA = "0x1B3CED0", Offset = "0x1B3C0D0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002363")]
		private static FirstQueryMatcher() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002362")]
		public FirstQueryMatcher() { }

		[Address(RVA = "0x1B3CE50", Offset = "0x1B3C050", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002361")]
		public virtual SingleQueryMatcher CreateNew() { }

		[Address(RVA = "0x1B3CEA0", Offset = "0x1B3C0A0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6002360")]
		protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	}

	[Token(Token = "0x20004A4")]
	public class IsOfType : IVisualPredicateWrapper
	{
		[Token(Token = "0x4000FB8")]
		public static IsOfType<T> s_Instance; //Field offset: 0x0

		[Address(RVA = "0xCBE5D0", Offset = "0xCBD7D0", Length = "0xEA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002350")]
		private static IsOfType`1() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600234F")]
		public IsOfType`1() { }

		[Address(RVA = "0xCBE590", Offset = "0xCBD790", Length = "0x3F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600234E")]
		public override bool Predicate(object e) { }

	}

	[Token(Token = "0x20004A3")]
	public interface IVisualPredicateWrapper
	{

		[Token(Token = "0x600234D")]
		public bool Predicate(object e) { }

	}

	[Token(Token = "0x20004A7")]
	public abstract class SingleQueryMatcher : UQueryMatcher
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000FBC")]
		private VisualElement <match>k__BackingField; //Field offset: 0x18

		[Token(Token = "0x17000959")]
		public VisualElement match
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600235A")]
			 get { } //Length: 5
			[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
			[CallerCount(Count = 9)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600235B")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600235F")]
		protected SingleQueryMatcher() { }

		[Token(Token = "0x600235E")]
		public abstract SingleQueryMatcher CreateNew() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600235A")]
		public VisualElement get_match() { }

		[Address(RVA = "0x1B3E120", Offset = "0x1B3D320", Length = "0xB")]
		[CalledBy(Type = typeof(UQueryState`1), Member = "Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SingleQueryMatcher)}, ReturnType = "T")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600235D")]
		public bool IsInUse() { }

		[Address(RVA = "0x1B3E130", Offset = "0x1B3D330", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600235C")]
		public virtual void Run(VisualElement root, List<RuleMatcher> matchers) { }

		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600235B")]
		public void set_match(VisualElement value) { }

	}

	[Token(Token = "0x20004A5")]
	public abstract class UQueryMatcher : HierarchyTraversal
	{
		[CompilerGenerated]
		[Token(Token = "0x20004A6")]
		private sealed class <>c
		{
			[Token(Token = "0x4000FBA")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000FBB")]
			public static Action<VisualElement, MatchResultInfo> <>9__5_0; //Field offset: 0x8

			[Address(RVA = "0x1B445F0", Offset = "0x1B437F0", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6002357")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002358")]
			public <>c() { }

			[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
			[CallerCount(Count = 8626)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002359")]
			internal void <TraverseRecursive>b__5_0(VisualElement e, MatchResultInfo i) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000FB9")]
		internal List<RuleMatcher> m_Matchers; //Field offset: 0x10

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002351")]
		protected UQueryMatcher() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002354")]
		private static void NoProcessResult(VisualElement e, MatchResultInfo i) { }

		[Address(RVA = "0x191DD80", Offset = "0x191CF80", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002353")]
		protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

		[Address(RVA = "0x1B4F570", Offset = "0x1B4E770", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002356")]
		public override void Run(VisualElement root, List<RuleMatcher> matchers) { }

		[Address(RVA = "0x1B4F7E0", Offset = "0x1B4E9E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HierarchyTraversal), Member = "Traverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002352")]
		public virtual void Traverse(VisualElement element) { }

		[Address(RVA = "0x1B4F5C0", Offset = "0x1B4E7C0", Length = "0x217")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(StyleSelectorHelper), Member = "MatchRightToLeft", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StyleComplexSelector), typeof(System.Action`2<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.StyleSheets.MatchResultInfo>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(HierarchyTraversal), Member = "Recurse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002355")]
		public virtual void TraverseRecursive(VisualElement element, int depth) { }

	}


}

