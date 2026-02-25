namespace UnityEngine.UIElements;

[Token(Token = "0x200000F")]
public struct BackgroundRepeat : IEquatable<BackgroundRepeat>
{
	[Token(Token = "0x2000010")]
	public class PropertyBag : ContainerPropertyBag<BackgroundRepeat>
	{
		[Token(Token = "0x2000011")]
		private class XProperty : Property<BackgroundRepeat, Repeat>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000020")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000021")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700000D")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x600004D")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700000C")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x600004C")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1AB76B0", Offset = "0x1AB68B0", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6000050")]
			public XProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600004D")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600004C")]
			public virtual string get_Name() { }

			[Address(RVA = "0x418BB0", Offset = "0x417DB0", Length = "0x3")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600004E")]
			public virtual Repeat GetValue(ref BackgroundRepeat container) { }

			[Address(RVA = "0x1A189C0", Offset = "0x1A17BC0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600004F")]
			public virtual void SetValue(ref BackgroundRepeat container, Repeat value) { }

		}

		[Token(Token = "0x2000012")]
		private class YProperty : Property<BackgroundRepeat, Repeat>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000022")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000023")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700000F")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6000052")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700000E")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6000051")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1AB77C0", Offset = "0x1AB69C0", Length = "0x159")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CallbackEventHandler), Member = "NotifyPropertyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingId&)}, ReturnType = typeof(void))]
			[Calls(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[CallsDeduplicatedMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6000055")]
			public YProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000052")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000051")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1AB7720", Offset = "0x1AB6920", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000053")]
			public virtual Repeat GetValue(ref BackgroundRepeat container) { }

			[Address(RVA = "0x1A18D00", Offset = "0x1A17F00", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000054")]
			public virtual void SetValue(ref BackgroundRepeat container, Repeat value) { }

		}


		[Address(RVA = "0x1AB57D0", Offset = "0x1AB49D0", Length = "0x175")]
		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600004B")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001E")]
	public Repeat x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400001F")]
	public Repeat y; //Field offset: 0x4

	[Address(RVA = "0x3AFE70", Offset = "0x3AF070", Length = "0x7")]
	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000043")]
	public BackgroundRepeat(Repeat repeatX, Repeat repeatY) { }

	[Address(RVA = "0x1A92E90", Offset = "0x1A92090", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000045")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1998A60", Offset = "0x1997C60", Length = "0x12")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000046")]
	public override bool Equals(BackgroundRepeat other) { }

	[Address(RVA = "0x1A92F20", Offset = "0x1A92120", Length = "0x3B")]
	[CalledBy(Type = typeof(VisualData), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StyleBackgroundRepeat), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000047")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x10267C0", Offset = "0x10259C0", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000044")]
	internal static BackgroundRepeat Initial() { }

	[Address(RVA = "0x1A92FF0", Offset = "0x1A921F0", Length = "0x15")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_backgroundRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundRepeat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundRepeat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualData), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualData), typeof(VisualData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleBackgroundRepeat), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundRepeat), typeof(StyleBackgroundRepeat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleBackgroundRepeat), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundRepeat)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleBackgroundRepeat), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000048")]
	public static bool op_Equality(BackgroundRepeat style1, BackgroundRepeat style2) { }

	[Address(RVA = "0x1A93010", Offset = "0x1A92210", Length = "0x18")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundRepeat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000049")]
	public static bool op_Inequality(BackgroundRepeat style1, BackgroundRepeat style2) { }

	[Address(RVA = "0x1A92F60", Offset = "0x1A92160", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x600004A")]
	public virtual string ToString() { }

}

