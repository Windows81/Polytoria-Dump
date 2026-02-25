namespace UnityEngine.UIElements;

[Token(Token = "0x20002F1")]
public struct EasingFunction : IEquatable<EasingFunction>
{
	[Token(Token = "0x20002F2")]
	public class PropertyBag : ContainerPropertyBag<EasingFunction>
	{
		[Token(Token = "0x20002F3")]
		private class ModeProperty : Property<EasingFunction, EasingMode>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000BF8")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000BF9")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000446")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001513")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000445")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001512")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1AE7F60", Offset = "0x1AE7160", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001516")]
			public ModeProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001513")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001512")]
			public virtual string get_Name() { }

			[Address(RVA = "0x418BB0", Offset = "0x417DB0", Length = "0x3")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001514")]
			public virtual EasingMode GetValue(ref EasingFunction container) { }

			[Address(RVA = "0x1A189C0", Offset = "0x1A17BC0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001515")]
			public virtual void SetValue(ref EasingFunction container, EasingMode value) { }

		}


		[Address(RVA = "0x1AE9360", Offset = "0x1AE8560", Length = "0xF2")]
		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001511")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BF7")]
	private EasingMode m_Mode; //Field offset: 0x0

	[Token(Token = "0x17000444")]
	public EasingMode mode
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001508")]
		 get { } //Length: 3
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001509")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600150A")]
	public EasingFunction(EasingMode mode) { }

	[Address(RVA = "0x1AD8D90", Offset = "0x1AD7F90", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600150D")]
	public override bool Equals(EasingFunction other) { }

	[Address(RVA = "0x1AD8D00", Offset = "0x1AD7F00", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600150E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001508")]
	public EasingMode get_mode() { }

	[Address(RVA = "0xF6BA50", Offset = "0xF6AC50", Length = "0x5")]
	[CallerCount(Count = 230)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001510")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x196BCA0", Offset = "0x196AEA0", Length = "0x8")]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600150C")]
	public static bool op_Equality(EasingFunction lhs, EasingFunction rhs) { }

	[Address(RVA = "0x1963880", Offset = "0x1962A80", Length = "0x5")]
	[CallerCount(Count = 45)]
	[DeduplicatedMethod]
	[Token(Token = "0x600150B")]
	public static EasingFunction op_Implicit(EasingMode easingMode) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001509")]
	public void set_mode(EasingMode value) { }

	[Address(RVA = "0x1AD8DA0", Offset = "0x1AD7FA0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x600150F")]
	public virtual string ToString() { }

}

