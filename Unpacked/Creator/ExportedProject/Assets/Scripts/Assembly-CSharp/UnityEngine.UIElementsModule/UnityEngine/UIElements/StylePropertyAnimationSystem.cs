namespace UnityEngine.UIElements;

[Token(Token = "0x2000432")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StylePropertyAnimationSystem : IStylePropertyAnimationSystem
{
	[Token(Token = "0x2000434")]
	private struct AnimationDataSet
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E00")]
		public VisualElement[] elements; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E01")]
		public StylePropertyId[] properties; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E02")]
		public TTimingData[] timing; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E03")]
		public TStyleData[] style; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E04")]
		public int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E05")]
		private Dictionary<ElementPropertyPair, Int32> indices; //Field offset: 0x0

		[Token(Token = "0x170008A6")]
		private int capacity
		{
			[Address(RVA = "0xA3B280", Offset = "0xA3A480", Length = "0x19")]
			[CallerCount(Count = 23)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001FB8")]
			private get { } //Length: 25
			[Address(RVA = "0xA3B920", Offset = "0xA3AB20", Length = "0xC7")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001FB9")]
			private set { } //Length: 199
		}

		[Address(RVA = "0xA34960", Offset = "0xA33B60", Length = "0x20E")]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "UpdateProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180067B10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FBD")]
		public void Add(VisualElement owner, StylePropertyId prop, TTimingData timingData, TStyleData styleData) { }

		[Address(RVA = "0xA35D50", Offset = "0xA34F50", Length = "0x73")]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(AnimationDataSet`2), Member = "LocalInit", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FBB")]
		public static AnimationDataSet<TTimingData, TStyleData> Create() { }

		[Address(RVA = "0xA3B280", Offset = "0xA3A480", Length = "0x19")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FB8")]
		private int get_capacity() { }

		[Address(RVA = "0xA368D0", Offset = "0xA35AD0", Length = "0xCD")]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "GetAllAnimations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyId>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FC2")]
		public void GetActivePropertiesForElement(VisualElement ve, List<StylePropertyId> outProperties) { }

		[Address(RVA = "0xA36E30", Offset = "0xA36030", Length = "0x9C")]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "CancelAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(long)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FBC")]
		public bool IndexOf(VisualElement ve, StylePropertyId prop, out int index) { }

		[Address(RVA = "0xA37FE0", Offset = "0xA371E0", Length = "0x1A6")]
		[CalledBy(Type = typeof(AnimationDataSet`2), Member = "Create", ReturnType = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TTimingData, TStyleData>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FBA")]
		private void LocalInit() { }

		[Address(RVA = "0xA3A680", Offset = "0xA39880", Length = "0x306")]
		[CalledBy(Type = typeof(AnimationDataSet`2), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "CancelAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(long)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FBE")]
		public void Remove(int cancelledIndex) { }

		[Address(RVA = "0xA38C00", Offset = "0xA37E00", Length = "0xA6")]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "CancelAllAnimations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(AnimationDataSet`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FC0")]
		public void RemoveAll(VisualElement ve) { }

		[Address(RVA = "0xA38190", Offset = "0xA37390", Length = "0xF5")]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "CancelAllAnimations", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180067B10")]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FC1")]
		public void RemoveAll() { }

		[Address(RVA = "0xA3B210", Offset = "0xA3A410", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FBF")]
		public void Replace(int index, TTimingData timingData, TStyleData styleData) { }

		[Address(RVA = "0xA3B920", Offset = "0xA3AB20", Length = "0xC7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FB9")]
		private void set_capacity(int value) { }

	}

	[Token(Token = "0x2000435")]
	private struct ElementPropertyPair
	{
		[Token(Token = "0x2000436")]
		private class EqualityComparer : IEqualityComparer<ElementPropertyPair>
		{

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001FC7")]
			public EqualityComparer() { }

			[Address(RVA = "0x1B0A450", Offset = "0x1B09650", Length = "0x19")]
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6001FC5")]
			public override bool Equals(ElementPropertyPair x, ElementPropertyPair y) { }

			[Address(RVA = "0x1B0A470", Offset = "0x1B09670", Length = "0x38")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x6001FC6")]
			public override int GetHashCode(ElementPropertyPair obj) { }

		}

		[Token(Token = "0x4000E06")]
		public static readonly IEqualityComparer<ElementPropertyPair> Comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E07")]
		public readonly VisualElement element; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000E08")]
		public readonly StylePropertyId property; //Field offset: 0x8

		[Address(RVA = "0x1B0A3D0", Offset = "0x1B095D0", Length = "0x73")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001FC4")]
		private static ElementPropertyPair() { }

		[Address(RVA = "0xC89AC0", Offset = "0xC88CC0", Length = "0x26")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FC3")]
		public ElementPropertyPair(VisualElement element, StylePropertyId property) { }

	}

	[Flags]
	[Token(Token = "0x2000433")]
	private enum TransitionState
	{
		None = 0,
		Running = 1,
		Started = 2,
		Ended = 4,
		Canceled = 8,
	}

	[Token(Token = "0x2000437")]
	private abstract class Values
	{

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FD1")]
		protected Values() { }

		[Token(Token = "0x6001FC8")]
		public abstract void CancelAllAnimations() { }

		[Token(Token = "0x6001FC9")]
		public abstract void CancelAllAnimations(VisualElement ve) { }

		[Token(Token = "0x6001FCA")]
		public abstract void CancelAnimation(VisualElement ve, StylePropertyId id) { }

		[Token(Token = "0x6001FCC")]
		public abstract void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds) { }

		[Token(Token = "0x6001FCD")]
		public abstract void Update(long currentTimeMs) { }

		[Token(Token = "0x6001FCB")]
		public abstract void UpdateAnimation(VisualElement ve, StylePropertyId id) { }

		[Token(Token = "0x6001FCF")]
		protected abstract void UpdateComputedStyle() { }

		[Token(Token = "0x6001FD0")]
		protected abstract void UpdateComputedStyle(int i) { }

		[Token(Token = "0x6001FCE")]
		protected abstract void UpdateValues() { }

	}

	[Token(Token = "0x2000438")]
	private abstract class Values : Values
	{
		[Token(Token = "0x200043D")]
		internal struct EmptyData
		{
			[Token(Token = "0x4000E1F")]
			public static EmptyData<T> Default; //Field offset: 0x0

			[Address(RVA = "0xAE02B0", Offset = "0xADF4B0", Length = "0x45")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001FF6")]
			private static EmptyData() { }

		}

		[Token(Token = "0x200043C")]
		internal struct StyleData
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E1B")]
			public T startValue; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E1C")]
			public T endValue; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E1D")]
			public T reversingAdjustedStartValue; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E1E")]
			public T currentValue; //Field offset: 0x0

		}

		[Token(Token = "0x200043B")]
		internal struct TimingData
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E14")]
			public long startTimeMs; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E15")]
			public int durationMs; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E16")]
			public Func<Single, Single> easingCurve; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E17")]
			public float easedProgress; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E18")]
			public float reversingShorteningFactor; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E19")]
			public bool isStarted; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E1A")]
			public int delayMs; //Field offset: 0x0

		}

		[Token(Token = "0x2000439")]
		private class TransitionEventsFrameState
		{
			[CompilerGenerated]
			[Token(Token = "0x200043A")]
			private sealed class <>c
			{
				[Token(Token = "0x4000E13")]
				public static readonly <>c<T> <>9; //Field offset: 0x0

				[Address(RVA = "0x7FC210", Offset = "0x7FB410", Length = "0xE9")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
				[CallsDeduplicatedMethods(Count = 1)]
				[DeduplicatedMethod]
				[Token(Token = "0x6001FF3")]
				private static <>c() { }

				[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
				[CallerCount(Count = 2609)]
				[CallsDeduplicatedMethods(Count = 1)]
				[DeduplicatedMethod]
				[Token(Token = "0x6001FF4")]
				public <>c() { }

				[Address(RVA = "0x7F96D0", Offset = "0x7F88D0", Length = "0x5A")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
				[CallsDeduplicatedMethods(Count = 1)]
				[DeduplicatedMethod]
				[Token(Token = "0x6001FF5")]
				internal Queue<EventBase> <.cctor>b__11_0() { }

			}

			[Token(Token = "0x4000E0E")]
			private static readonly ObjectPool<Queue`1<EventBase>> k_EventQueuePool; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E0F")]
			public readonly Dictionary<ElementPropertyPair, TransitionState> elementPropertyStateDelta; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E10")]
			public readonly Dictionary<ElementPropertyPair, Queue`1<EventBase>> elementPropertyQueuedEvents; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E11")]
			public IPanel panel; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E12")]
			private int m_ChangesCount; //Field offset: 0x0

			[Address(RVA = "0x1007040", Offset = "0x1006240", Length = "0x1D4")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001FF2")]
			private static TransitionEventsFrameState() { }

			[Address(RVA = "0x10094A0", Offset = "0x10086A0", Length = "0x113")]
			[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = ".ctor", ReturnType = typeof(void))]
			[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1", Member = ".ctor", ReturnType = typeof(void))]
			[CallerCount(Count = 4)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001FF1")]
			public TransitionEventsFrameState() { }

			[Address(RVA = "0x10055D0", Offset = "0x10047D0", Length = "0x373")]
			[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "ProcessEventQueue", ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(ObjectPool`1), Member = "get_CountInactive", ReturnType = typeof(int))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(Queue`1), Member = "Clear", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 2)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001FF0")]
			public void Clear() { }

			[Address(RVA = "0x1006B90", Offset = "0x1005D90", Length = "0xBD")]
			[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair"}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004CFE0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001FEC")]
			public static Queue<EventBase> GetPooledQueue() { }

			[Address(RVA = "0x1006C50", Offset = "0x1005E50", Length = "0x4")]
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001FED")]
			public void RegisterChange() { }

			[Address(RVA = "0x1006C60", Offset = "0x1005E60", Length = "0xA")]
			[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6001FEF")]
			public bool StateChanged() { }

			[Address(RVA = "0x1006C70", Offset = "0x1005E70", Length = "0x4")]
			[CallerCount(Count = 4)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001FEE")]
			public void UnregisterChange() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E09")]
		private long m_CurrentTimeMs; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E0A")]
		private TransitionEventsFrameState<T> m_CurrentFrameEventsState; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E0B")]
		private TransitionEventsFrameState<T> m_NextFrameEventsState; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E0C")]
		public AnimationDataSet<TimingData<T>, StyleData<T>> running; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E0D")]
		public AnimationDataSet<EmptyData<T>, T> completed; //Field offset: 0x0

		[Token(Token = "0x170008A7")]
		public bool isEmpty
		{
			[Address(RVA = "0x8E33E0", Offset = "0x8E25E0", Length = "0xA")]
			[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<T>"}, ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "UpdateTracking", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<T>"}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6001FD2")]
			 get { } //Length: 10
		}

		[Token(Token = "0x170008A8")]
		public abstract Func<T, T, Boolean> SameFunc
		{
			[Token(Token = "0x6001FD3")]
			 get { } //Length: 0
		}

		[Address(RVA = "0x8E2D60", Offset = "0x8E1F60", Length = "0x195")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "Create", ReturnType = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "Create", ReturnType = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TTimingData, TStyleData>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FD6")]
		protected Values`1() { }

		[Address(RVA = "0x8D0D10", Offset = "0x8CFF10", Length = "0x31D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Values`1), Member = "SendTransitionCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(EventDispatcherGate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004BCB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(EventDispatcherGate), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FE0")]
		public virtual void CancelAllAnimations(VisualElement ve) { }

		[Address(RVA = "0x8D1030", Offset = "0x8D0230", Length = "0x505")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(EventDispatcherGate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Values`1), Member = "SendTransitionCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(EventDispatcherGate), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "RemoveAll", ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "RemoveAll", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FDF")]
		public virtual void CancelAllAnimations() { }

		[Address(RVA = "0x8D2BB0", Offset = "0x8D1DB0", Length = "0x1D3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Values`1), Member = "QueueTransitionCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004BCB0")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FE1")]
		public virtual void CancelAnimation(VisualElement ve, StylePropertyId id) { }

		[Address(RVA = "0x8D3FF0", Offset = "0x8D31F0", Length = "0x10F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Dequeue", ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FD9")]
		private void ClearEventQueue(ElementPropertyPair epp) { }

		[Address(RVA = "0x8D4100", Offset = "0x8D3300", Length = "0x26")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FE6")]
		private int ComputeReversingDelay(int delayMs, float newReversingShorteningFactor) { }

		[Address(RVA = "0x8D4130", Offset = "0x8D3330", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FE5")]
		private int ComputeReversingDuration(int newTransitionDurationMs, float newReversingShorteningFactor) { }

		[Address(RVA = "0x8D4150", Offset = "0x8D3350", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FE4")]
		private float ComputeReversingShorteningFactor(int oldIndex) { }

		[Address(RVA = "0x8D41C0", Offset = "0x8D33C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FD4")]
		protected override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref T a, ref T b) { }

		[Address(RVA = "0x8D4240", Offset = "0x8D3440", Length = "0x14")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FD5")]
		protected override T Copy(T value) { }

		[Address(RVA = "0x8D4300", Offset = "0x8D3500", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FE8")]
		private void ForceComputedStyleEndValue(int runningIndex) { }

		[Address(RVA = "0x8E33E0", Offset = "0x8E25E0", Length = "0xA")]
		[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<T>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "UpdateTracking", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FD2")]
		public bool get_isEmpty() { }

		[Token(Token = "0x6001FD3")]
		public abstract Func<T, T, Boolean> get_SameFunc() { }

		[Address(RVA = "0x8D4520", Offset = "0x8D3720", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "GetActivePropertiesForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyId>)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "GetActivePropertiesForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StylePropertyId>)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FE3")]
		public virtual void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds) { }

		[Address(RVA = "0x8D4B20", Offset = "0x8D3D20", Length = "0x2E6")]
		[CalledBy(Type = typeof(Values`1), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(EventDispatcherGate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventDispatcher)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Dequeue", ReturnType = typeof(object))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState", Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(EventDispatcherGate), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FEA")]
		private void ProcessEventQueue() { }

		[Address(RVA = "0x8D5E80", Offset = "0x8D5080", Length = "0x1B8")]
		[CalledBy(Type = typeof(Values`1), Member = "QueueTransitionRunEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Values`1), Member = "QueueTransitionStartEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Values`1), Member = "QueueTransitionEndEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Values`1), Member = "QueueTransitionCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(long)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState", Member = "GetPooledQueue", ReturnType = typeof(System.Collections.Generic.Queue`1<UnityEngine.UIElements.EventBase>))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FD8")]
		private void QueueEvent(EventBase evt, ElementPropertyPair epp) { }

		[Address(RVA = "0x8D7B00", Offset = "0x8D6D00", Length = "0x2F4")]
		[CalledBy(Type = typeof(Values`1), Member = "CancelAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Values`1), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(long)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Values`1), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32Enum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32Enum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18004BB00")]
		[Calls(Type = typeof(StylePropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TransitionEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName), typeof(double)}, ReturnType = "T")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FDD")]
		private void QueueTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs) { }

		[Address(RVA = "0x8D84F0", Offset = "0x8D76F0", Length = "0x246")]
		[CalledBy(Type = typeof(Values`1), Member = "UpdateProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32Enum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32Enum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StylePropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TransitionEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName), typeof(double)}, ReturnType = "T")]
		[Calls(Type = typeof(Values`1), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FDC")]
		private void QueueTransitionEndEvent(VisualElement ve, int runningIndex) { }

		[Address(RVA = "0x8D97B0", Offset = "0x8D89B0", Length = "0x257")]
		[CalledBy(Type = typeof(Values`1), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(long)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32Enum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32Enum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StylePropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TransitionEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName), typeof(double)}, ReturnType = "T")]
		[Calls(Type = typeof(Values`1), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FDA")]
		private void QueueTransitionRunEvent(VisualElement ve, int runningIndex) { }

		[Address(RVA = "0x8DAD10", Offset = "0x8D9F10", Length = "0x257")]
		[CalledBy(Type = typeof(Values`1), Member = "UpdateProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32Enum>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair, System.Int32Enum>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair", "System.Int32Enum"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(StylePropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TransitionEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName), typeof(double)}, ReturnType = "T")]
		[Calls(Type = typeof(Values`1), Member = "QueueEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventBase), "UnityEngine.UIElements.StylePropertyAnimationSystem+ElementPropertyPair"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FDB")]
		private void QueueTransitionStartEvent(VisualElement ve, int runningIndex) { }

		[Address(RVA = "0x8DBB70", Offset = "0x8DAD70", Length = "0x1F5")]
		[CalledBy(Type = typeof(Values`1), Member = "CancelAllAnimations", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Values`1), Member = "CancelAllAnimations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(VisualElement), Member = "HasParentEventInterests", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventCategory)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(StylePropertyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TransitionEventBase`1), Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyName), typeof(double)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FDE")]
		private void SendTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs) { }

		[Address(RVA = "0x8DD940", Offset = "0x8DCB40", Length = "0xC03")]
		[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<T>"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Background>+TimingData<Background>", "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Background>+StyleData<Background>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Values`1), Member = "QueueTransitionCancelEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC070")]
		[Calls(Type = typeof(Values`1), Member = "QueueTransitionRunEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Background>+TimingData<Background>", "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Background>+StyleData<Background>"}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 19)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FE7")]
		public bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve, long currentTimeMs) { }

		[Address(RVA = "0x8E04A0", Offset = "0x8DF6A0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FD7")]
		private void SwapFrameStates() { }

		[Address(RVA = "0x8E27D0", Offset = "0x8E19D0", Length = "0xA5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Values`1), Member = "UpdateProgress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState", Member = "StateChanged", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Values`1), Member = "ProcessEventQueue", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FE9")]
		public virtual void Update(long currentTimeMs) { }

		[Address(RVA = "0x8E0630", Offset = "0x8DF830", Length = "0x64")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FE2")]
		public virtual void UpdateAnimation(VisualElement ve, StylePropertyId id) { }

		[Address(RVA = "0x8E0FE0", Offset = "0x8E01E0", Length = "0x412")]
		[CalledBy(Type = typeof(Values`1), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Values`1), Member = "QueueTransitionStartEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "TTimingData", "TStyleData"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
		[Calls(Type = typeof(Values`1), Member = "QueueTransitionEndEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FEB")]
		private void UpdateProgress(long currentTimeMs) { }

	}

	[Token(Token = "0x2000444")]
	private class ValuesBackground : ValuesDiscrete<Background>
	{

		[Address(RVA = "0x1B20120", Offset = "0x1B1F320", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600201E")]
		public ValuesBackground() { }

		[Address(RVA = "0x1B1FF30", Offset = "0x1B1F130", Length = "0xB5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Background)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600201D")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x1B1FFF0", Offset = "0x1B1F1F0", Length = "0x129")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Background)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600201C")]
		protected virtual void UpdateComputedStyle() { }

	}

	[Token(Token = "0x200044C")]
	private class ValuesBackgroundPosition : ValuesDiscrete<BackgroundPosition>
	{

		[Address(RVA = "0x1B3A9A0", Offset = "0x1B39BA0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1<BackgroundPosition>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600204C")]
		public ValuesBackgroundPosition() { }

		[Address(RVA = "0x1B3A8E0", Offset = "0x1B39AE0", Length = "0xB8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundPosition)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600204B")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x1B3A7C0", Offset = "0x1B399C0", Length = "0x115")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundPosition)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600204A")]
		protected virtual void UpdateComputedStyle() { }

	}

	[Token(Token = "0x200044D")]
	private class ValuesBackgroundRepeat : ValuesDiscrete<BackgroundRepeat>
	{

		[Address(RVA = "0x1B3AB80", Offset = "0x1B39D80", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1<BackgroundRepeat>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600204F")]
		public ValuesBackgroundRepeat() { }

		[Address(RVA = "0x1B3A9E0", Offset = "0x1B39BE0", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundRepeat)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600204E")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x1B3AA80", Offset = "0x1B39C80", Length = "0xF7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundRepeat)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600204D")]
		protected virtual void UpdateComputedStyle() { }

	}

	[Token(Token = "0x200044E")]
	private class ValuesBackgroundSize : Values<BackgroundSize>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E2A")]
		private readonly Func<BackgroundSize, BackgroundSize, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x170008B3")]
		public virtual Func<BackgroundSize, BackgroundSize, Boolean> SameFunc
		{
			[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002050")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x1B3B090", Offset = "0x1B3A290", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<BackgroundSize>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6002057")]
		public ValuesBackgroundSize() { }

		[Address(RVA = "0x1B3ABC0", Offset = "0x1B39DC0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "TryConvertBackgroundSizeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize&), typeof(BackgroundSize&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002052")]
		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref BackgroundSize a, ref BackgroundSize b) { }

		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002050")]
		public virtual Func<BackgroundSize, BackgroundSize, Boolean> get_SameFunc() { }

		[Address(RVA = "0x1B3ABF0", Offset = "0x1B39DF0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BackgroundSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6002051")]
		private static bool IsSame(BackgroundSize a, BackgroundSize b) { }

		[Address(RVA = "0x1B3AC30", Offset = "0x1B39E30", Length = "0xBF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BackgroundSize), Member = "get_x", ReturnType = typeof(Length))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(Length))]
		[Calls(Type = typeof(BackgroundSize), Member = "get_y", ReturnType = typeof(Length))]
		[Calls(Type = typeof(BackgroundSize), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002055")]
		private static BackgroundSize Lerp(BackgroundSize a, BackgroundSize b, float t) { }

		[Address(RVA = "0x1B3ADB0", Offset = "0x1B39FB0", Length = "0x121")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundSize)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002053")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x1B3ACF0", Offset = "0x1B39EF0", Length = "0xB6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundSize)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002054")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x1B3AEE0", Offset = "0x1B3A0E0", Length = "0x1A8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BackgroundSize), Member = "get_x", ReturnType = typeof(Length))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(Length))]
		[Calls(Type = typeof(BackgroundSize), Member = "get_y", ReturnType = typeof(Length))]
		[Calls(Type = typeof(BackgroundSize), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002056")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x2000441")]
	private class ValuesColor : Values<Color>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E23")]
		private readonly Func<Color, Color, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x170008AC")]
		public virtual Func<Color, Color, Boolean> SameFunc
		{
			[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600200D")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x1B20560", Offset = "0x1B1F760", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Color>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6002013")]
		public ValuesColor() { }

		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600200D")]
		public virtual Func<Color, Color, Boolean> get_SameFunc() { }

		[Address(RVA = "0x1B20160", Offset = "0x1B1F360", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Token(Token = "0x600200E")]
		private static bool IsSame(Color c, Color d) { }

		[Address(RVA = "0x1B201E0", Offset = "0x1B1F3E0", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600200F")]
		private static Color Lerp(Color a, Color b, float t) { }

		[Address(RVA = "0x1B20330", Offset = "0x1B1F530", Length = "0x10A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002011")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x1B20280", Offset = "0x1B1F480", Length = "0xAB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002012")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x1B20440", Offset = "0x1B1F640", Length = "0x117")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002010")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x2000442")]
	private abstract class ValuesDiscrete : Values<T>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E24")]
		private readonly Func<T, T, Boolean> <SameFunc>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x170008AD")]
		public virtual Func<T, T, Boolean> SameFunc
		{
			[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002014")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x8CF0E0", Offset = "0x8CE2E0", Length = "0x20B")]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackground", Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1+TransitionEventsFrameState", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>", Member = "Create", ReturnType = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TimingData<Background>, StyleData<Background>>")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2", Member = "Create", ReturnType = "UnityEngine.UIElements.StylePropertyAnimationSystem+AnimationDataSet`2<TTimingData, TStyleData>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002018")]
		protected ValuesDiscrete`1() { }

		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002014")]
		public virtual Func<T, T, Boolean> get_SameFunc() { }

		[Address(RVA = "0x8CD870", Offset = "0x8CCA70", Length = "0x190")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.UIElements.Background>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.UIElements.Background>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002015")]
		private static bool IsSame(T a, T b) { }

		[Address(RVA = "0x8CE080", Offset = "0x8CD280", Length = "0x30")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002016")]
		private static T Lerp(T a, T b, float t) { }

		[Address(RVA = "0x8CE210", Offset = "0x8CD410", Length = "0xDC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002017")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x2000443")]
	private class ValuesEnum : ValuesDiscrete<Int32>
	{

		[Address(RVA = "0x1B207A0", Offset = "0x1B1F9A0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1<Int32>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600201B")]
		public ValuesEnum() { }

		[Address(RVA = "0x1B20600", Offset = "0x1B1F800", Length = "0x98")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x600201A")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x1B206A0", Offset = "0x1B1F8A0", Length = "0xF7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002019")]
		protected virtual void UpdateComputedStyle() { }

	}

	[Token(Token = "0x200043E")]
	private class ValuesFloat : Values<Single>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E20")]
		private readonly Func<Single, Single, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x170008A9")]
		public virtual Func<Single, Single, Boolean> SameFunc
		{
			[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001FF7")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x1B20A40", Offset = "0x1B1FC40", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Func`3<System.Single, System.Single, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Single>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001FFD")]
		public ValuesFloat() { }

		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FF7")]
		public virtual Func<Single, Single, Boolean> get_SameFunc() { }

		[Address(RVA = "0x1B207E0", Offset = "0x1B1F9E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Token(Token = "0x6001FF8")]
		private static bool IsSame(float a, float b) { }

		[Address(RVA = "0x1B207F0", Offset = "0x1B1F9F0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001FF9")]
		private static void Lerp(float a, float b, ref float result, float t) { }

		[Address(RVA = "0x1B20810", Offset = "0x1B1FA10", Length = "0xF8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6001FFB")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x1B20910", Offset = "0x1B1FB10", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6001FFC")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x1B209B0", Offset = "0x1B1FBB0", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6001FFA")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x2000446")]
	private class ValuesFont : ValuesDiscrete<Font>
	{

		[Address(RVA = "0x1B20E80", Offset = "0x1B20080", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1<Object>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6002024")]
		public ValuesFont() { }

		[Address(RVA = "0x1B20CE0", Offset = "0x1B1FEE0", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Font)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002023")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x1B20D80", Offset = "0x1B1FF80", Length = "0xF7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Font)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002022")]
		protected virtual void UpdateComputedStyle() { }

	}

	[Token(Token = "0x2000445")]
	private class ValuesFontDefinition : ValuesDiscrete<FontDefinition>
	{

		[Address(RVA = "0x1B20CA0", Offset = "0x1B1FEA0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesDiscrete`1<FontDefinition>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6002021")]
		public ValuesFontDefinition() { }

		[Address(RVA = "0x1B20AE0", Offset = "0x1B1FCE0", Length = "0xAB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(FontDefinition)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002020")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x1B20B90", Offset = "0x1B1FD90", Length = "0x10A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(FontDefinition)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600201F")]
		protected virtual void UpdateComputedStyle() { }

	}

	[Token(Token = "0x200043F")]
	private class ValuesInt : Values<Int32>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E21")]
		private readonly Func<Int32, Int32, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x170008AA")]
		public virtual Func<Int32, Int32, Boolean> SameFunc
		{
			[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001FFE")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x1B211B0", Offset = "0x1B203B0", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Func`3<System.Int32, System.Int32, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Int32>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6002004")]
		public ValuesInt() { }

		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FFE")]
		public virtual Func<Int32, Int32, Boolean> get_SameFunc() { }

		[Address(RVA = "0x7C7930", Offset = "0x7C6B30", Length = "0x6")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001FFF")]
		private static bool IsSame(int a, int b) { }

		[Address(RVA = "0x1B20EC0", Offset = "0x1B200C0", Length = "0x110")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002000")]
		private static int Lerp(int a, int b, float t) { }

		[Address(RVA = "0x1B206A0", Offset = "0x1B1F8A0", Length = "0xF7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002002")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x1B20600", Offset = "0x1B1F800", Length = "0x98")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002003")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x1B20FD0", Offset = "0x1B201D0", Length = "0x1D1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002001")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x2000440")]
	private class ValuesLength : Values<Length>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E22")]
		private readonly Func<Length, Length, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x170008AB")]
		public virtual Func<Length, Length, Boolean> SameFunc
		{
			[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002005")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x1B215C0", Offset = "0x1B207C0", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Length>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600200C")]
		public ValuesLength() { }

		[Address(RVA = "0x1B21250", Offset = "0x1B20450", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "TryConvertLengthUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(Length&), typeof(Length&), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002007")]
		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Length a, ref Length b) { }

		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002005")]
		public virtual Func<Length, Length, Boolean> get_SameFunc() { }

		[Address(RVA = "0x1B21290", Offset = "0x1B20490", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Token(Token = "0x6002006")]
		private static bool IsSame(Length a, Length b) { }

		[Address(RVA = "0x1B212D0", Offset = "0x1B204D0", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate), typeof(float)}, ReturnType = typeof(Translate))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTranslate", Member = "UpdateValues", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTransformOrigin", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin), typeof(TransformOrigin), typeof(float)}, ReturnType = typeof(TransformOrigin))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesTransformOrigin", Member = "UpdateValues", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize), typeof(float)}, ReturnType = typeof(BackgroundSize))]
		[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesBackgroundSize", Member = "UpdateValues", ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Token(Token = "0x6002008")]
		internal static Length Lerp(Length a, Length b, float t) { }

		[Address(RVA = "0x1B21330", Offset = "0x1B20530", Length = "0xF7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600200A")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x1B21430", Offset = "0x1B20630", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600200B")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x1B214D0", Offset = "0x1B206D0", Length = "0xE8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002009")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x2000449")]
	private class ValuesRotate : Values<Rotate>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E27")]
		private readonly Func<Rotate, Rotate, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x170008B0")]
		public virtual Func<Rotate, Rotate, Boolean> SameFunc
		{
			[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002033")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x1B3B5D0", Offset = "0x1B3A7D0", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Rotate>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6002039")]
		public ValuesRotate() { }

		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002033")]
		public virtual Func<Rotate, Rotate, Boolean> get_SameFunc() { }

		[Address(RVA = "0x1B3B130", Offset = "0x1B3A330", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Rotate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6002034")]
		private static bool IsSame(Rotate a, Rotate b) { }

		[Address(RVA = "0x1B3B180", Offset = "0x1B3A380", Length = "0xA4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Angle), Member = "ToDegrees", ReturnType = typeof(float))]
		[Calls(Type = typeof(Rotate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Angle), typeof(Vector3)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002037")]
		private static Rotate Lerp(Rotate a, Rotate b, float t) { }

		[Address(RVA = "0x1B3B2F0", Offset = "0x1B3A4F0", Length = "0x125")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Rotate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002035")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x1B3B230", Offset = "0x1B3A430", Length = "0xB8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Rotate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002036")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x1B3B420", Offset = "0x1B3A620", Length = "0x1A7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Angle), Member = "ToDegrees", ReturnType = typeof(float))]
		[Calls(Type = typeof(Rotate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Angle), typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002038")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x2000448")]
	private class ValuesScale : Values<Scale>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E26")]
		private readonly Func<Scale, Scale, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x170008AF")]
		public virtual Func<Scale, Scale, Boolean> SameFunc
		{
			[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600202C")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x1B3BA10", Offset = "0x1B3AC10", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Scale>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6002032")]
		public ValuesScale() { }

		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600202C")]
		public virtual Func<Scale, Scale, Boolean> get_SameFunc() { }

		[Address(RVA = "0x1B3B670", Offset = "0x1B3A870", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Scale), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale), typeof(Scale)}, ReturnType = typeof(bool))]
		[Token(Token = "0x600202D")]
		private static bool IsSame(Scale a, Scale b) { }

		[Address(RVA = "0x1B3B6A0", Offset = "0x1B3A8A0", Length = "0x7C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Scale), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002030")]
		private static Scale Lerp(Scale a, Scale b, float t) { }

		[Address(RVA = "0x1B3B7D0", Offset = "0x1B3A9D0", Length = "0x10A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Scale)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600202E")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x1B3B720", Offset = "0x1B3A920", Length = "0xAB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Scale)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600202F")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x1B3B8E0", Offset = "0x1B3AAE0", Length = "0x12B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Scale), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002031")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x2000447")]
	private class ValuesTextShadow : Values<TextShadow>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E25")]
		private readonly Func<TextShadow, TextShadow, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x170008AE")]
		public virtual Func<TextShadow, TextShadow, Boolean> SameFunc
		{
			[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002025")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x1B3BEE0", Offset = "0x1B3B0E0", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Func`3<UnityEngine.UIElements.TextShadow, UnityEngine.UIElements.TextShadow, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<TextShadow>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600202B")]
		public ValuesTextShadow() { }

		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002025")]
		public virtual Func<TextShadow, TextShadow, Boolean> get_SameFunc() { }

		[Address(RVA = "0x1B3BAB0", Offset = "0x1B3ACB0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextShadow), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6002026")]
		private static bool IsSame(TextShadow a, TextShadow b) { }

		[Address(RVA = "0x1B3BB00", Offset = "0x1B3AD00", Length = "0x82")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextShadow), Member = "LerpUnclamped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow), typeof(float)}, ReturnType = typeof(TextShadow))]
		[Token(Token = "0x6002027")]
		private static TextShadow Lerp(TextShadow a, TextShadow b, float t) { }

		[Address(RVA = "0x1B3BC60", Offset = "0x1B3AE60", Length = "0x13C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TextShadow)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002029")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x1B3BB90", Offset = "0x1B3AD90", Length = "0xCA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TextShadow)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600202A")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x1B3BDA0", Offset = "0x1B3AFA0", Length = "0x137")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextShadow), Member = "LerpUnclamped", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow), typeof(float)}, ReturnType = typeof(TextShadow))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002028")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x200044B")]
	private class ValuesTransformOrigin : Values<TransformOrigin>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E29")]
		private readonly Func<TransformOrigin, TransformOrigin, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x170008B2")]
		public virtual Func<TransformOrigin, TransformOrigin, Boolean> SameFunc
		{
			[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002042")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x1B3C470", Offset = "0x1B3B670", Length = "0x93")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<TransformOrigin>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6002049")]
		public ValuesTransformOrigin() { }

		[Address(RVA = "0x1B3BF80", Offset = "0x1B3B180", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "TryConvertTransformOriginUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin&), typeof(TransformOrigin&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002044")]
		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref TransformOrigin a, ref TransformOrigin b) { }

		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002042")]
		public virtual Func<TransformOrigin, TransformOrigin, Boolean> get_SameFunc() { }

		[Address(RVA = "0x1B3BFB0", Offset = "0x1B3B1B0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TransformOrigin), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin), typeof(TransformOrigin)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6002043")]
		private static bool IsSame(TransformOrigin a, TransformOrigin b) { }

		[Address(RVA = "0x1B3BFF0", Offset = "0x1B3B1F0", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(Length))]
		[Calls(Type = typeof(TransformOrigin), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002047")]
		private static TransformOrigin Lerp(TransformOrigin a, TransformOrigin b, float t) { }

		[Address(RVA = "0x1B3C170", Offset = "0x1B3B370", Length = "0x121")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TransformOrigin)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002045")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x1B3C0B0", Offset = "0x1B3B2B0", Length = "0xB6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TransformOrigin)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002046")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x1B3C2A0", Offset = "0x1B3B4A0", Length = "0x1C6")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(Length))]
		[Calls(Type = typeof(TransformOrigin), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002048")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x200044A")]
	private class ValuesTranslate : Values<Translate>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E28")]
		private readonly Func<Translate, Translate, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x170008B1")]
		public virtual Func<Translate, Translate, Boolean> SameFunc
		{
			[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600203A")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x1B3CA10", Offset = "0x1B3BC10", Length = "0x1AD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<Translate>", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
		[Token(Token = "0x6002041")]
		public ValuesTranslate() { }

		[Address(RVA = "0x1B3C510", Offset = "0x1B3B710", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "TryConvertTranslateUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate&), typeof(Translate&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600203C")]
		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Translate a, ref Translate b) { }

		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600203A")]
		public virtual Func<Translate, Translate, Boolean> get_SameFunc() { }

		[Address(RVA = "0x1B3C540", Offset = "0x1B3B740", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Translate), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate), typeof(Translate)}, ReturnType = typeof(bool))]
		[Token(Token = "0x600203B")]
		private static bool IsSame(Translate a, Translate b) { }

		[Address(RVA = "0x1B3C590", Offset = "0x1B3B790", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(Length))]
		[Calls(Type = typeof(Translate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(void))]
		[Token(Token = "0x600203F")]
		private static Translate Lerp(Translate a, Translate b, float t) { }

		[Address(RVA = "0x1B3C710", Offset = "0x1B3B910", Length = "0x125")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Translate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600203D")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x1B3C650", Offset = "0x1B3B850", Length = "0xB8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
		[Calls(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Translate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600203E")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x1B3C840", Offset = "0x1B3BA40", Length = "0x1C5")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesLength", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(Length))]
		[Calls(Type = typeof(Translate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length), typeof(Length), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002040")]
		protected virtual void UpdateValues() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DE7")]
	private long m_CurrentTimeMs; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DE8")]
	private ValuesFloat m_Floats; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000DE9")]
	private ValuesInt m_Ints; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000DEA")]
	private ValuesLength m_Lengths; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000DEB")]
	private ValuesColor m_Colors; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000DEC")]
	private ValuesEnum m_Enums; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000DED")]
	private ValuesBackground m_Backgrounds; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000DEE")]
	private ValuesFontDefinition m_FontDefinitions; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000DEF")]
	private ValuesFont m_Fonts; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000DF0")]
	private ValuesTextShadow m_TextShadows; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000DF1")]
	private ValuesScale m_Scale; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000DF2")]
	private ValuesRotate m_Rotate; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000DF3")]
	private ValuesTranslate m_Translate; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000DF4")]
	private ValuesTransformOrigin m_TransformOrigin; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000DF5")]
	private ValuesBackgroundPosition m_BackgroundPosition; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000DF6")]
	private ValuesBackgroundRepeat m_BackgroundRepeat; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000DF7")]
	private ValuesBackgroundSize m_BackgroundSize; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000DF8")]
	private readonly List<Values> m_AllValues; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000DF9")]
	private readonly Dictionary<StylePropertyId, Values> m_PropertyToValues; //Field offset: 0xA0

	[Address(RVA = "0x1B18E60", Offset = "0x1B18060", Length = "0xFE")]
	[CalledBy(Type = typeof(Panel), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(ContextType), typeof(EventDispatcher)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001F9D")]
	public StylePropertyAnimationSystem() { }

	[Address(RVA = "0x1B17AE0", Offset = "0x1B16CE0", Length = "0x1CA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Assert), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001FB1")]
	public override void CancelAllAnimations(VisualElement owner) { }

	[Address(RVA = "0x1B179D0", Offset = "0x1B16BD0", Length = "0x10A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001FB0")]
	public override void CancelAllAnimations() { }

	[Address(RVA = "0x1B17CB0", Offset = "0x1B16EB0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001FB2")]
	public override void CancelAnimation(VisualElement owner, StylePropertyId id) { }

	[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
	[CallerCount(Count = 196)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FB6")]
	private long CurrentTimeMs() { }

	[Address(RVA = "0x1B17D50", Offset = "0x1B16F50", Length = "0x129")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001FB4")]
	public override void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds) { }

	[Address(RVA = "0x763450", Offset = "0x762650", Length = "0x53")]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TextShadow), typeof(TextShadow), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundPosition), typeof(BackgroundPosition), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TransformOrigin), typeof(TransformOrigin), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Translate), typeof(Translate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Rotate), typeof(Rotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Scale), typeof(Scale), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Font), typeof(Font), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundRepeat), typeof(BackgroundRepeat), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(FontDefinition), typeof(FontDefinition), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransitionEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int), typeof(int), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Color), typeof(Color), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length), typeof(Length), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int), typeof(int), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float), typeof(float), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Background), typeof(Background), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundSize), typeof(BackgroundSize), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F9E")]
	private T GetOrCreate(ref T values) { }

	[Address(RVA = "0x1B18580", Offset = "0x1B17780", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundSize), typeof(BackgroundSize), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.BackgroundSize>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001FAF")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1B18C10", Offset = "0x1B17E10", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundRepeat), typeof(BackgroundRepeat), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.BackgroundRepeat>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001FAE")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1B17F40", Offset = "0x1B17140", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundPosition), typeof(BackgroundPosition), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.BackgroundPosition>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001FAD")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1B183C0", Offset = "0x1B175C0", Length = "0xF1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TransformOrigin), typeof(TransformOrigin), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.TransformOrigin>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001FAC")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1B18B10", Offset = "0x1B17D10", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Translate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Translate), typeof(Translate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.Translate>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001FAB")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1B18680", Offset = "0x1B17880", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Rotate), typeof(Rotate), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.Rotate>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001FAA")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1B18780", Offset = "0x1B17980", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TextShadow), typeof(TextShadow), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.TextShadow>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001FA8")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1B18A40", Offset = "0x1B17C40", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(object), typeof(object), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<System.Object>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001FA7")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1B18130", Offset = "0x1B17330", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontDefinition)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(FontDefinition), typeof(FontDefinition), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.FontDefinition>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001FA6")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1B18030", Offset = "0x1B17230", Length = "0xF5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), "UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<T>"}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001FA5")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1B182E0", Offset = "0x1B174E0", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Color), typeof(Color), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.Color>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001FA3")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1B18210", Offset = "0x1B17410", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length), typeof(Length), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.Length>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001FA2")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1B184C0", Offset = "0x1B176C0", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int), typeof(int), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<System.Int32>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001FA1")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1B18890", Offset = "0x1B17A90", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float), typeof(float), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<System.Single>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001FA0")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x7639D0", Offset = "0x762BD0", Length = "0x1C5")]
	[CalledBy(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Background), typeof(Background), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Values`1), Member = "StartTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), "T", "T", typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(long)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Values`1), Member = "get_isEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F9F")]
	private bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve, Values<T> values) { }

	[Address(RVA = "0x1B18960", Offset = "0x1B17B60", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Scale), typeof(Scale), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<UnityEngine.UIElements.Scale>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001FA9")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1B17E80", Offset = "0x1B17080", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "GetOrCreate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = "T")]
	[Calls(Type = typeof(StylePropertyAnimationSystem), Member = "StartTransition", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int), typeof(int), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>), typeof(UnityEngine.UIElements.StylePropertyAnimationSystem+Values`1<System.Int32>)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001FA4")]
	public override bool StartTransitionEnum(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x1B18D80", Offset = "0x1B17F80", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Panel), Member = "TimeSinceStartupMs", ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001FB7")]
	public override void Update() { }

	[Address(RVA = "0x1B18CE0", Offset = "0x1B17EE0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32Enum, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum", typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001FB3")]
	public override void UpdateAnimation(VisualElement owner, StylePropertyId id) { }

	[Address(RVA = "0x765060", Offset = "0x764260", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Values`1), Member = "get_isEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FB5")]
	private void UpdateTracking(Values<T> values) { }

}

