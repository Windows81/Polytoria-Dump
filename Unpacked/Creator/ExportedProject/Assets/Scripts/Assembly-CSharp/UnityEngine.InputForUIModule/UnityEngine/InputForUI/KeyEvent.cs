namespace UnityEngine.InputForUI;

[Token(Token = "0x2000010")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct KeyEvent : IEventProperties
{
	[Token(Token = "0x2000012")]
	internal struct ButtonsState
	{
		[CompilerGenerated]
		[Token(Token = "0x2000014")]
		[UnsafeValueType]
		internal struct <buttons>e__FixedBuffer
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000065")]
			public byte FixedElementField; //Field offset: 0x0

		}

		[CompilerGenerated]
		[Token(Token = "0x2000013")]
		private sealed class <GetAllPressed>d__8 : IEnumerable<KeyCode>, IEnumerable, IEnumerator<KeyCode>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400005F")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4000060")]
			private KeyCode <>2__current; //Field offset: 0x14
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000061")]
			private int <>l__initialThreadId; //Field offset: 0x18
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4000062")]
			public ButtonsState <>4__this; //Field offset: 0x1C
			[FieldOffset(Offset = "0x44")]
			[Token(Token = "0x4000063")]
			public ButtonsState <>3__<>4__this; //Field offset: 0x44
			[FieldOffset(Offset = "0x6C")]
			[Token(Token = "0x4000064")]
			private uint <index>5__1; //Field offset: 0x6C

			[Token(Token = "0x17000020")]
			private override KeyCode System.Collections.Generic.IEnumerator<UnityEngine.KeyCode>.Current
			{
				[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
				[CallerCount(Count = 0)]
				[DebuggerHidden]
				[DeduplicatedMethod]
				[Token(Token = "0x6000049")]
				private get { } //Length: 4
			}

			[Token(Token = "0x17000021")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x19D8E20", Offset = "0x19D8020", Length = "0x43")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
				[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
				[DebuggerHidden]
				[Token(Token = "0x600004B")]
				private get { } //Length: 67
			}

			[Address(RVA = "0x158E220", Offset = "0x158D420", Length = "0x436")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[Calls(Type = "System.Linq.Expressions.Interpreter.TryCatchFinallyHandler", Member = "get_IsFinallyBlockExist", ReturnType = typeof(bool))]
			[CallsDeduplicatedMethods(Count = 2)]
			[CallsUnknownMethods(Count = 3)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000046")]
			public <GetAllPressed>d__8(int <>1__state) { }

			[Address(RVA = "0x19D8CD0", Offset = "0x19D7ED0", Length = "0x5D")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6000048")]
			private override bool MoveNext() { }

			[Address(RVA = "0x19D8D30", Offset = "0x19D7F30", Length = "0xA5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 3)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600004C")]
			private override IEnumerator<KeyCode> System.Collections.Generic.IEnumerable<UnityEngine.KeyCode>.GetEnumerator() { }

			[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000049")]
			private override KeyCode System.Collections.Generic.IEnumerator<UnityEngine.KeyCode>.get_Current() { }

			[Address(RVA = "0x19D8D30", Offset = "0x19D7F30", Length = "0xA5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 3)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600004D")]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[Address(RVA = "0x19D8E20", Offset = "0x19D8020", Length = "0x43")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DebuggerHidden]
			[Token(Token = "0x600004B")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x19D8DE0", Offset = "0x19D7FE0", Length = "0x3E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DebuggerHidden]
			[Token(Token = "0x600004A")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
			[CallerCount(Count = 8626)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000047")]
			private override void System.IDisposable.Dispose() { }

		}

		[FieldOffset(Offset = "0x0")]
		[FixedBuffer(typeof(byte), 40)]
		[Token(Token = "0x400005E")]
		private <buttons>e__FixedBuffer buttons; //Field offset: 0x0

		[Address(RVA = "0x19CFA20", Offset = "0x19CEC20", Length = "0x17")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000040")]
		private void ClearUnchecked(uint index) { }

		[Address(RVA = "0x19CFA40", Offset = "0x19CEC40", Length = "0x7A")]
		[CalledBy(Type = typeof(ButtonsState), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 2)]
		[IteratorStateMachine(typeof(<GetAllPressed>d__8))]
		[Token(Token = "0x6000042")]
		public IEnumerable<KeyCode> GetAllPressed() { }

		[Address(RVA = "0x19CFAC0", Offset = "0x19CECC0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600003E")]
		private bool GetUnchecked(uint index) { }

		[Address(RVA = "0x19CFAF0", Offset = "0x19CECF0", Length = "0x28")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000041")]
		public bool IsPressed(KeyCode keyCode) { }

		[Address(RVA = "0x19CFB20", Offset = "0x19CED20", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000044")]
		public void Reset() { }

		[Address(RVA = "0x19CFB40", Offset = "0x19CED40", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000043")]
		public void SetPressed(KeyCode keyCode, bool pressed) { }

		[Address(RVA = "0x19CFB70", Offset = "0x19CED70", Length = "0x17")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600003F")]
		private void SetUnchecked(uint index) { }

		[Address(RVA = "0x19CFBB0", Offset = "0x19CEDB0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600003D")]
		internal static bool ShouldBeProcessed(KeyCode keyCode) { }

		[Address(RVA = "0x19CFBC0", Offset = "0x19CEDC0", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ButtonsState), Member = "GetAllPressed", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.KeyCode>))]
		[Calls(Type = typeof(string), Member = "Join", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.IEnumerable`1<System.Int32Enum>)}, ReturnType = typeof(string))]
		[Token(Token = "0x6000045")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x2000011")]
	internal enum Type
	{
		KeyPressed = 1,
		KeyRepeated = 2,
		KeyReleased = 3,
		State = 4,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000052")]
	public Type type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000053")]
	public KeyCode keyCode; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000054")]
	public ButtonsState buttonsState; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000055")]
	private DiscreteTime <timestamp>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000056")]
	private EventSource <eventSource>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000057")]
	private uint <playerId>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000058")]
	private EventModifiers <eventModifiers>k__BackingField; //Field offset: 0x40

	[Token(Token = "0x1700001F")]
	public override EventModifiers eventModifiers
	{
		[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600003A")]
		 get { } //Length: 4
		[Address(RVA = "0x324370", Offset = "0x323570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600003B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001D")]
	public override EventSource eventSource
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000037")]
		 get { } //Length: 4
		[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000038")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001E")]
	public uint playerId
	{
		[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000039")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001C")]
	public DiscreteTime timestamp
	{
		[Address(RVA = "0x105F9B0", Offset = "0x105EBB0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000036")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x600003A")]
	public override EventModifiers get_eventModifiers() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000037")]
	public override EventSource get_eventSource() { }

	[Address(RVA = "0x324370", Offset = "0x323570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600003B")]
	public void set_eventModifiers(EventModifiers value) { }

	[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000038")]
	public void set_eventSource(EventSource value) { }

	[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000039")]
	public void set_playerId(uint value) { }

	[Address(RVA = "0x105F9B0", Offset = "0x105EBB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000036")]
	public void set_timestamp(DiscreteTime value) { }

	[Address(RVA = "0x19D70E0", Offset = "0x19D62E0", Length = "0x140")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600003C")]
	public virtual string ToString() { }

}

