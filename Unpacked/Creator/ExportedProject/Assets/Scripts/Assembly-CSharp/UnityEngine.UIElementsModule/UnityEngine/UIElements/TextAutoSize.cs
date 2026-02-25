namespace UnityEngine.UIElements;

[Token(Token = "0x200048B")]
public struct TextAutoSize : IEquatable<TextAutoSize>
{
	[Token(Token = "0x200048C")]
	public class PropertyBag : ContainerPropertyBag<TextAutoSize>
	{
		[Token(Token = "0x200048F")]
		private class MaxSizeProperty : Property<TextAutoSize, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000F8B")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000F8C")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000930")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6002292")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700092F")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6002291")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1B3D9F0", Offset = "0x1B3CBF0", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6002295")]
			public MaxSizeProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002292")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002291")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1B3D9D0", Offset = "0x1B3CBD0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6002293")]
			public virtual Length GetValue(ref TextAutoSize container) { }

			[Address(RVA = "0x1B3D9E0", Offset = "0x1B3CBE0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6002294")]
			public virtual void SetValue(ref TextAutoSize container, Length value) { }

		}

		[Token(Token = "0x200048E")]
		private class MinSizeProperty : Property<TextAutoSize, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000F89")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000F8A")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700092E")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x600228D")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700092D")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x600228C")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1B3DA60", Offset = "0x1B3CC60", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6002290")]
			public MinSizeProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600228D")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600228C")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1AB5740", Offset = "0x1AB4940", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600228E")]
			public virtual Length GetValue(ref TextAutoSize container) { }

			[Address(RVA = "0x1AB5750", Offset = "0x1AB4950", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600228F")]
			public virtual void SetValue(ref TextAutoSize container, Length value) { }

		}

		[Token(Token = "0x200048D")]
		private class ModeProperty : Property<TextAutoSize, TextAutoSizeMode>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000F87")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000F88")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700092C")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6002288")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700092B")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6002287")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1B3DAD0", Offset = "0x1B3CCD0", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600228B")]
			public ModeProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002288")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002287")]
			public virtual string get_Name() { }

			[Address(RVA = "0x418BB0", Offset = "0x417DB0", Length = "0x3")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002289")]
			public virtual TextAutoSizeMode GetValue(ref TextAutoSize container) { }

			[Address(RVA = "0x1A189C0", Offset = "0x1A17BC0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600228A")]
			public virtual void SetValue(ref TextAutoSize container, TextAutoSizeMode value) { }

		}


		[Address(RVA = "0x1B3DCD0", Offset = "0x1B3CED0", Length = "0x204")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x6002286")]
		public PropertyBag() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000F84")]
	private TextAutoSizeMode <mode>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000F85")]
	private Length <minSize>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000F86")]
	private Length <maxSize>k__BackingField; //Field offset: 0xC

	[Token(Token = "0x1700092A")]
	public Length maxSize
	{
		[Address(RVA = "0x1B3EC10", Offset = "0x1B3DE10", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600227E")]
		 get { } //Length: 5
		[Address(RVA = "0x19DC1A0", Offset = "0x19DB3A0", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600227F")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000929")]
	public Length minSize
	{
		[Address(RVA = "0xCE3870", Offset = "0xCE2A70", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600227C")]
		 get { } //Length: 5
		[Address(RVA = "0x18733F0", Offset = "0x18725F0", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600227D")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000928")]
	public TextAutoSizeMode mode
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600227A")]
		 get { } //Length: 3
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600227B")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x1B3EA00", Offset = "0x1B3DC00", Length = "0x66")]
	[CalledBy(Type = typeof(StyleTextAutoSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize), typeof(StyleTextAutoSize)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleTextAutoSize), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleTextAutoSize), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002281")]
	public override bool Equals(TextAutoSize other) { }

	[Address(RVA = "0x1B3EA70", Offset = "0x1B3DC70", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002282")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1B3EC10", Offset = "0x1B3DE10", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600227E")]
	public Length get_maxSize() { }

	[Address(RVA = "0xCE3870", Offset = "0xCE2A70", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600227C")]
	public Length get_minSize() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600227A")]
	public TextAutoSizeMode get_mode() { }

	[Address(RVA = "0x1B3EB40", Offset = "0x1B3DD40", Length = "0x6D")]
	[CalledBy(Type = typeof(RareData), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StyleTextAutoSize), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002283")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B3EBB0", Offset = "0x1B3DDB0", Length = "0x58")]
	[CalledBy(Type = typeof(StyleValueExtensions), Member = "ToTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = typeof(TextAutoSize))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextAutoSize))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(StylePropertyValue)}, ReturnType = typeof(TextAutoSize))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Token(Token = "0x6002280")]
	public static TextAutoSize None() { }

	[Address(RVA = "0x1B3EC20", Offset = "0x1B3DE20", Length = "0x68")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "UnityEngine.UIElements.IStyle.set_unityTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetInlineTextAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RareData), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RareData), typeof(RareData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RareData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RareData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002284")]
	public static bool op_Equality(TextAutoSize left, TextAutoSize right) { }

	[Address(RVA = "0x1B3EC90", Offset = "0x1B3DE90", Length = "0x7A")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CalledBy(Type = typeof(UITKTextHandle), Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(System.Nullable`1<System.Single>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002285")]
	public static bool op_Inequality(TextAutoSize left, TextAutoSize right) { }

	[Address(RVA = "0x19DC1A0", Offset = "0x19DB3A0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600227F")]
	public void set_maxSize(Length value) { }

	[Address(RVA = "0x18733F0", Offset = "0x18725F0", Length = "0x5")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600227D")]
	public void set_minSize(Length value) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600227B")]
	public void set_mode(TextAutoSizeMode value) { }

}

