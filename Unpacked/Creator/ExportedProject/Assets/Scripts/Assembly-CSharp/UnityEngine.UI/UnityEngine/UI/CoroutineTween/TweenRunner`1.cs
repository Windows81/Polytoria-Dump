namespace UnityEngine.UI.CoroutineTween;

[Token(Token = "0x2000090")]
internal class TweenRunner
{
	[CompilerGenerated]
	[Token(Token = "0x2000091")]
	private sealed class <Start>d__2 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000289")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028A")]
		private object <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028B")]
		public T tweenInfo; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028C")]
		private float <elapsedTime>5__2; //Field offset: 0x0

		[Token(Token = "0x17000168")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600058E")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000169")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000590")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600058B")]
		public <Start>d__2(int <>1__state) { }

		[Address(RVA = "0x81A640", Offset = "0x819840", Length = "0x125")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Time), Member = "get_unscaledDeltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(ColorTween), Member = "TweenValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600058D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600058E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000590")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600058F")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600058C")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000287")]
	protected MonoBehaviour m_CoroutineContainer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000288")]
	protected IEnumerator m_Tween; //Field offset: 0x0

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600058A")]
	public TweenRunner`1() { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000587")]
	public void Init(MonoBehaviour coroutineContainer) { }

	[Address(RVA = "0x10164F0", Offset = "0x10156F0", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<Start>d__2))]
	[Token(Token = "0x6000586")]
	private static IEnumerator Start(T tweenInfo) { }

	[Address(RVA = "0x10157C0", Offset = "0x10149C0", Length = "0x23E")]
	[CalledBy(Type = typeof(Graphic), Member = "CrossFadeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(float), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ColorTween), Member = "TweenValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000588")]
	public void StartTween(T info) { }

	[Address(RVA = "0x10165C0", Offset = "0x10157C0", Length = "0x48")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000589")]
	public void StopTween() { }

}

