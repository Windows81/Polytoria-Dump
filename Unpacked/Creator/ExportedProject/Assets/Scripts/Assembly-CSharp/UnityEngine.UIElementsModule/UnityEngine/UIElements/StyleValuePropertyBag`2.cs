namespace UnityEngine.UIElements;

[Token(Token = "0x200040A")]
internal class StyleValuePropertyBag : ContainerPropertyBag<TContainer>
{
	[Token(Token = "0x200040C")]
	private class KeywordProperty : Property<TContainer, StyleKeyword>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000D75")]
		private readonly string <Name>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000D76")]
		private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700088B")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F14")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700088A")]
		public virtual string Name
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F13")]
			 get { } //Length: 5
		}

		[Address(RVA = "0xCE4C60", Offset = "0xCE3E60", Length = "0x6C")]
		[CalledBy(Type = typeof(StyleValuePropertyBag`2), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F17")]
		public KeywordProperty() { }

		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F14")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F13")]
		public virtual string get_Name() { }

		[Address(RVA = "0xCE4080", Offset = "0xCE3280", Length = "0x17")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F15")]
		public virtual StyleKeyword GetValue(ref TContainer container) { }

		[Address(RVA = "0xCE4300", Offset = "0xCE3500", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F16")]
		public virtual void SetValue(ref TContainer container, StyleKeyword value) { }

	}

	[Token(Token = "0x200040B")]
	private class ValueProperty : Property<TContainer, TValue>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000D73")]
		private readonly string <Name>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000D74")]
		private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000889")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F0F")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000888")]
		public virtual string Name
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6001F0E")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x86EF30", Offset = "0x86E130", Length = "0x6C")]
		[CalledBy(Type = typeof(StyleValuePropertyBag`2), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F12")]
		public ValueProperty() { }

		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F0F")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F0E")]
		public virtual string get_Name() { }

		[Address(RVA = "0x86E300", Offset = "0x86D500", Length = "0x17")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F10")]
		public virtual TValue GetValue(ref TContainer container) { }

		[Address(RVA = "0x86E900", Offset = "0x86DB00", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F11")]
		public virtual void SetValue(ref TContainer container, TValue value) { }

	}


	[Address(RVA = "0xF6C210", Offset = "0xF6B410", Length = "0x131")]
	[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ValueProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeywordProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F0D")]
	public StyleValuePropertyBag`2() { }

}

