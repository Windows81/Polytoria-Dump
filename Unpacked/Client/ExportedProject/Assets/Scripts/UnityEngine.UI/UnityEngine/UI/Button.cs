namespace UnityEngine.UI;

[AddComponentMenu("UI/Button", 30)]
[Token(Token = "0x2000005")]
public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler
{
	[CompilerGenerated]
	[Token(Token = "0x2000007")]
	private sealed class <OnFinishSubmit>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000011")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000012")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000013")]
		public Button <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000014")]
		private float <fadeTime>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000015")]
		private float <elapsedTime>5__3; //Field offset: 0x2C

		[Token(Token = "0x17000007")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000019")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000008")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600001B")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000016")]
		public <OnFinishSubmit>d__9(int <>1__state) { }

		[Address(RVA = "0x1A91930", Offset = "0x1A90B30", Length = "0x12D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Time), Member = "get_unscaledDeltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Selectable), Member = "get_currentSelectionState", ReturnType = "UnityEngine.UI.Selectable+SelectionState")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000018")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000019")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600001B")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x1A91A60", Offset = "0x1A90C60", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x600001A")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000017")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000006")]
	internal class ButtonClickedEvent : UnityEvent
	{

		[Address(RVA = "0x1A76700", Offset = "0x1A75900", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEvent), Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6000015")]
		public ButtonClickedEvent() { }

	}

	[FieldOffset(Offset = "0x100")]
	[FormerlySerializedAs("onClick")]
	[SerializeField]
	[Token(Token = "0x4000010")]
	private ButtonClickedEvent m_OnClick; //Field offset: 0x100

	[Token(Token = "0x17000006")]
	public ButtonClickedEvent onClick
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000F")]
		 get { } //Length: 8
		[Address(RVA = "0x507950", Offset = "0x506B50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000010")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x1A76920", Offset = "0x1A75B20", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600000E")]
	protected Button() { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000F")]
	public ButtonClickedEvent get_onClick() { }

	[Address(RVA = "0x1A76710", Offset = "0x1A75910", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<OnFinishSubmit>d__9))]
	[Token(Token = "0x6000014")]
	private IEnumerator OnFinishSubmit() { }

	[Address(RVA = "0x1A76780", Offset = "0x1A75980", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Button), Member = "Press", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000012")]
	public override void OnPointerClick(PointerEventData eventData) { }

	[Address(RVA = "0x1A767B0", Offset = "0x1A759B0", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Button), Member = "Press", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000013")]
	public override void OnSubmit(BaseEventData eventData) { }

	[Address(RVA = "0x1A76890", Offset = "0x1A75A90", Length = "0x8E")]
	[CalledBy(Type = typeof(Button), Member = "OnPointerClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Button), Member = "OnSubmit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseEventData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent), Member = "Invoke", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000011")]
	private void Press() { }

	[Address(RVA = "0x507950", Offset = "0x506B50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000010")]
	public void set_onClick(ButtonClickedEvent value) { }

}

