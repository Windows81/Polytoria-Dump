namespace UnityEngine.UIElements;

[Token(Token = "0x20003F9")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct StyleDataRef : IEquatable<StyleDataRef`1<T>>
{
	[Token(Token = "0x20003FA")]
	private class RefCounted
	{
		[Token(Token = "0x4000D51")]
		private static uint m_NextId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000D52")]
		private int m_RefCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000D53")]
		private readonly uint m_Id; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000D54")]
		public T value; //Field offset: 0x0

		[Token(Token = "0x1700086D")]
		public int refCount
		{
			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001E51")]
			 get { } //Length: 4
		}

		[Address(RVA = "0xF0BE80", Offset = "0xF0B080", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E56")]
		private static RefCounted() { }

		[Address(RVA = "0xF0C020", Offset = "0xF0B220", Length = "0xBB")]
		[CalledBy(Type = typeof(StyleDataRef`1), Member = "Create", ReturnType = "UnityEngine.UIElements.StyleDataRef`1<T>")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E52")]
		public RefCounted() { }

		[Address(RVA = "0xF0B130", Offset = "0xF0A330", Length = "0x4")]
		[CalledBy(Type = typeof(StyleDataRef`1), Member = "Acquire", ReturnType = "UnityEngine.UIElements.StyleDataRef`1<T>")]
		[CalledBy(Type = typeof(StyleDataRef`1), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleDataRef`1<T>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E53")]
		public void Acquire() { }

		[Address(RVA = "0xF0B490", Offset = "0xF0A690", Length = "0x1AB")]
		[CalledBy(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E55")]
		public RefCounted<T> Copy() { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E51")]
		public int get_refCount() { }

		[Address(RVA = "0xF0BE70", Offset = "0xF0B070", Length = "0x4")]
		[CalledBy(Type = typeof(StyleDataRef`1), Member = "Release", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StyleDataRef`1), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleDataRef`1<T>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StyleDataRef`1), Member = "Write", ReturnType = "T&")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E54")]
		public void Release() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D50")]
	private RefCounted<T> m_Ref; //Field offset: 0x0

	[Address(RVA = "0xF66160", Offset = "0xF65360", Length = "0x50")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(ComputedStyle))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "Acquire", ReturnType = typeof(ComputedStyle))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(RefCounted), Member = "Acquire", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E46")]
	public StyleDataRef<T> Acquire() { }

	[Address(RVA = "0xF66850", Offset = "0xF65A50", Length = "0x116")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(RefCounted), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RefCounted), Member = "Acquire", ReturnType = typeof(void))]
	[Calls(Type = typeof(InheritedData), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InheritedData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E48")]
	public void CopyFrom(StyleDataRef<T> other) { }

	[Address(RVA = "0xF66BB0", Offset = "0xF65DB0", Length = "0x93")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CreateInitial", ReturnType = typeof(ComputedStyle))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RefCounted), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E4B")]
	public static StyleDataRef<T> Create() { }

	[Address(RVA = "0xF678D0", Offset = "0xF66AD0", Length = "0x101")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(InheritedData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InheritedData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E4E")]
	public override bool Equals(StyleDataRef<T> other) { }

	[Address(RVA = "0xF677C0", Offset = "0xF669C0", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F8A70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E4F")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xF67DE0", Offset = "0xF66FE0", Length = "0x4C")]
	[CalledBy(Type = typeof(VisualTreeStyleUpdaterTraversal), Member = "TraverseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(InheritedData), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E4C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xF687F0", Offset = "0xF679F0", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(InheritedData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InheritedData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E4D")]
	public static bool op_Equality(StyleDataRef<T> lhs, StyleDataRef<T> rhs) { }

	[Address(RVA = "0xF67E30", Offset = "0xF67030", Length = "0x1A")]
	[CallerCount(Count = 393)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E49")]
	public T Read() { }

	[Address(RVA = "0xF67EA0", Offset = "0xF670A0", Length = "0x9")]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E50")]
	public bool ReferenceEquals(StyleDataRef<T> other) { }

	[Address(RVA = "0xF67EB0", Offset = "0xF670B0", Length = "0x5D")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "Release", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(RefCounted), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E47")]
	public void Release() { }

	[Address(RVA = "0xF68080", Offset = "0xF67280", Length = "0xCA")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(FontDefinition)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InitialStyle), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyUnsetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyInitialValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(TextShadow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Font)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "ApplyUnityTextOutline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyStyleTextShadow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValue), typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "FinalizeApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 78)]
	[Calls(Type = typeof(RefCounted), Member = "Copy", ReturnType = "UnityEngine.UIElements.StyleDataRef`1<T>+RefCounted<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RefCounted), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E4A")]
	public T Write() { }

}

