namespace UnityEngine.UIElements;

[Token(Token = "0x20002DF")]
public struct Angle : IEquatable<Angle>
{
	[Token(Token = "0x20002E1")]
	public class PropertyBag : ContainerPropertyBag<Angle>
	{
		[Token(Token = "0x20002E3")]
		private class UnitProperty : Property<Angle, AngleUnit>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000BA9")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000BAA")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170003DF")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x600141B")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170003DE")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x600141A")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1AEC2F0", Offset = "0x1AEB4F0", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600141E")]
			public UnitProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600141B")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600141A")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1AB7720", Offset = "0x1AB6920", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600141C")]
			public virtual AngleUnit GetValue(ref Angle container) { }

			[Address(RVA = "0x1A18D00", Offset = "0x1A17F00", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600141D")]
			public virtual void SetValue(ref Angle container, AngleUnit value) { }

		}

		[Token(Token = "0x20002E2")]
		private class ValueProperty : Property<Angle, Single>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000BA7")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000BA8")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x170003DD")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001416")]
				 get { } //Length: 5
			}

			[Token(Token = "0x170003DC")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6001415")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1AEE580", Offset = "0x1AED780", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001419")]
			public ValueProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001416")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001415")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1A13380", Offset = "0x1A12580", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001417")]
			public virtual float GetValue(ref Angle container) { }

			[Address(RVA = "0x1A13390", Offset = "0x1A12590", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001418")]
			public virtual void SetValue(ref Angle container, float value) { }

		}


		[Address(RVA = "0x1AE91D0", Offset = "0x1AE83D0", Length = "0x181")]
		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6001414")]
		public PropertyBag() { }

	}

	[Token(Token = "0x20002E0")]
	private enum Unit
	{
		Degree = 0,
		Gradian = 1,
		Radian = 2,
		Turn = 3,
		None = 4,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B9F")]
	private float m_Value; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000BA0")]
	private Unit m_Unit; //Field offset: 0x4

	[Token(Token = "0x170003DB")]
	public AngleUnit unit
	{
		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001407")]
		 get { } //Length: 4
		[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001408")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170003DA")]
	public float value
	{
		[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001405")]
		 get { } //Length: 5
		[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001406")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x9DF730", Offset = "0x9DE930", Length = "0x9")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x600140A")]
	public Angle(float value, AngleUnit unit) { }

	[Address(RVA = "0x9DF730", Offset = "0x9DE930", Length = "0x9")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x600140B")]
	private Angle(float value, Unit unit) { }

	[Address(RVA = "0x1AD2A90", Offset = "0x1AD1C90", Length = "0x2D")]
	[CallerCount(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001410")]
	public override bool Equals(Angle other) { }

	[Address(RVA = "0x1AD29E0", Offset = "0x1AD1BE0", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001411")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001407")]
	public AngleUnit get_unit() { }

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001405")]
	public float get_value() { }

	[Address(RVA = "0x1AD2AC0", Offset = "0x1AD1CC0", Length = "0x1F")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001412")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1AD2AE0", Offset = "0x1AD1CE0", Length = "0x8")]
	[CalledBy(Type = typeof(StyleSheet), Member = "WriteAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle&), typeof(Angle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheetUtility), Member = "ToDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Angle)}, ReturnType = typeof(Dimension))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001409")]
	internal bool IsNone() { }

	[Address(RVA = "0x1AD2AF0", Offset = "0x1AD1CF0", Length = "0x16")]
	[CalledBy(Type = typeof(StyleSheet), Member = "ReadAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Angle))]
	[CalledBy(Type = typeof(StyleSheet), Member = "TryReadAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Angle&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue)}, ReturnType = typeof(Angle))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x6001404")]
	internal static Angle None() { }

	[Address(RVA = "0x1AD2D40", Offset = "0x1AD1F40", Length = "0x2A")]
	[CallerCount(Count = 34)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600140E")]
	public static bool op_Equality(Angle lhs, Angle rhs) { }

	[Address(RVA = "0x1AD2D70", Offset = "0x1AD1F70", Length = "0x14")]
	[CallerCount(Count = 27)]
	[DeduplicatedMethod]
	[Token(Token = "0x600140D")]
	public static Angle op_Implicit(float value) { }

	[Address(RVA = "0x1AD2D90", Offset = "0x1AD1F90", Length = "0x2A")]
	[CallerCount(Count = 57)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600140F")]
	public static bool op_Inequality(Angle lhs, Angle rhs) { }

	[Address(RVA = "0x3B8830", Offset = "0x3B7A30", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001408")]
	public void set_unit(AngleUnit value) { }

	[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001406")]
	public void set_value(float value) { }

	[Address(RVA = "0x1AD2B10", Offset = "0x1AD1D10", Length = "0x56")]
	[CalledBy(Type = typeof(Rotate), Member = "ToQuaternion", ReturnType = typeof(Quaternion))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesRotate", Member = "Lerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate), typeof(Rotate), typeof(float)}, ReturnType = typeof(Rotate))]
	[CalledBy(Type = "UnityEngine.UIElements.StylePropertyAnimationSystem+ValuesRotate", Member = "UpdateValues", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Token(Token = "0x600140C")]
	public float ToDegrees() { }

	[Address(RVA = "0x1AD2B70", Offset = "0x1AD1D70", Length = "0x1C7")]
	[CalledBy(Type = typeof(Rotate), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001413")]
	public virtual string ToString() { }

}

