namespace MoonSharp.Interpreter;

[Token(Token = "0x2000040")]
public class Coroutine : RefIdObject, IScriptPrivateResource
{
	[CompilerGenerated]
	[Token(Token = "0x2000042")]
	private sealed class <AsEnumerable>d__12 : IEnumerable<Object>, IEnumerable, IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001AB")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001AC")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001AD")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001AE")]
		public Coroutine <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001AF")]
		private IEnumerator<DynValue> <>7__wrap1; //Field offset: 0x30

		[Token(Token = "0x1700008B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60004B5")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700008C")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60004B7")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004B1")]
		public <AsEnumerable>d__12(int <>1__state) { }

		[Address(RVA = "0x3134F0", Offset = "0x3126F0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x60004B4")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x313160", Offset = "0x312360", Length = "0x215")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Coroutine), Member = "AsTypedEnumerable", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<MoonSharp.Interpreter.DynValue>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(DynValue), Member = "ToScalar", ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(ScriptToClrConversions), Member = "DynValueToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F59D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x60004B3")]
		private override bool MoveNext() { }

		[Address(RVA = "0x313380", Offset = "0x312580", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004B8")]
		private override IEnumerator<Object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004B5")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x313380", Offset = "0x312580", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004B9")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004B7")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x313420", Offset = "0x312620", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60004B6")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x313460", Offset = "0x312660", Length = "0x8C")]
		[CalledBy(Type = typeof(UnitySourceGeneratedAssemblyMonoScriptTypes_v1), Member = "Get", ReturnType = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1+MonoScriptData")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F59E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[Token(Token = "0x60004B2")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000043")]
	private sealed class <AsEnumerable>d__13 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B0")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B1")]
		private T <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B2")]
		private int <>l__initialThreadId; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B3")]
		public Coroutine <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B4")]
		private IEnumerator<DynValue> <>7__wrap1; //Field offset: 0x0

		[Token(Token = "0x1700008D")]
		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Address(RVA = "0x7F3980", Offset = "0x7F2B80", Length = "0xAC")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60004BE")]
			private get { } //Length: 172
		}

		[Token(Token = "0x1700008E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x7F3A90", Offset = "0x7F2C90", Length = "0xAD")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60004C0")]
			private get { } //Length: 173
		}

		[Address(RVA = "0x7F3CD0", Offset = "0x7F2ED0", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004BA")]
		public <AsEnumerable>d__13`1(int <>1__state) { }

		[Address(RVA = "0x7F3BE0", Offset = "0x7F2DE0", Length = "0xE6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004BD")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x7F32F0", Offset = "0x7F24F0", Length = "0x501")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807F3170")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(Coroutine), Member = "AsTypedEnumerable", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<MoonSharp.Interpreter.DynValue>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(DynValue), Member = "ToScalar", ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEC40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004BC")]
		private override bool MoveNext() { }

		[Address(RVA = "0x7F3800", Offset = "0x7F2A00", Length = "0x170")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C1")]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[Address(RVA = "0x7F3980", Offset = "0x7F2B80", Length = "0xAC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004BE")]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[Address(RVA = "0x7F3A30", Offset = "0x7F2C30", Length = "0x18")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C2")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x7F3A90", Offset = "0x7F2C90", Length = "0xAD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C0")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x7F3A50", Offset = "0x7F2C50", Length = "0x39")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004BF")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x7F3B40", Offset = "0x7F2D40", Length = "0x95")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004BB")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000044")]
	private sealed class <AsTypedEnumerable>d__11 : IEnumerable<DynValue>, IEnumerable, IEnumerator<DynValue>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001B5")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001B6")]
		private DynValue <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001B7")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001B8")]
		public Coroutine <>4__this; //Field offset: 0x28

		[Token(Token = "0x1700008F")]
		private override DynValue System.Collections.Generic.IEnumerator<MoonSharp.Interpreter.DynValue>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60004C6")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000090")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60004C8")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C3")]
		public <AsTypedEnumerable>d__11(int <>1__state) { }

		[Address(RVA = "0x313570", Offset = "0x312770", Length = "0x156")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Coroutine), Member = "Resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004C5")]
		private override bool MoveNext() { }

		[Address(RVA = "0x3136D0", Offset = "0x3128D0", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C9")]
		private override IEnumerator<DynValue> System.Collections.Generic.IEnumerable<MoonSharp.Interpreter.DynValue>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C6")]
		private override DynValue System.Collections.Generic.IEnumerator<MoonSharp.Interpreter.DynValue>.get_Current() { }

		[Address(RVA = "0x3136D0", Offset = "0x3128D0", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004CA")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C8")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x313770", Offset = "0x312970", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60004C7")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004C4")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000045")]
	private sealed class <AsUnityCoroutine>d__14 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001B9")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001BA")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001BB")]
		public Coroutine <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001BC")]
		private IEnumerator<DynValue> <>7__wrap1; //Field offset: 0x28

		[Token(Token = "0x17000091")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60004CF")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000092")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60004D1")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004CB")]
		public <AsUnityCoroutine>d__14(int <>1__state) { }

		[Address(RVA = "0x313A70", Offset = "0x312C70", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x60004CE")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x3137B0", Offset = "0x3129B0", Length = "0x1E8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Coroutine), Member = "AsTypedEnumerable", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<MoonSharp.Interpreter.DynValue>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5A50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x60004CD")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004CF")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60004D1")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x3139A0", Offset = "0x312BA0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60004D0")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x3139E0", Offset = "0x312BE0", Length = "0x8C")]
		[CalledBy(Type = typeof(UnitySourceGeneratedAssemblyMonoScriptTypes_v1), Member = "Get", ReturnType = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1+MonoScriptData")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5920")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[Token(Token = "0x60004CC")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000041")]
	internal enum CoroutineType
	{
		Coroutine = 0,
		ClrCallback = 1,
		ClrCallbackDead = 2,
		Recycled = 3,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001A2")]
	private CoroutineType <Type>k__BackingField; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001A3")]
	private CallbackFunction m_ClrCallback; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001A4")]
	private Processor m_Processor; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001A5")]
	private Script <OwnerScript>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x1700008A")]
	public long AutoYieldCounter
	{
		[Address(RVA = "0x2F83F0", Offset = "0x2F75F0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004AF")]
		 get { } //Length: 27
		[Address(RVA = "0x2F8450", Offset = "0x2F7650", Length = "0x1B")]
		[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<InvokeEvent>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<RunScriptInstance>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004B0")]
		 set { } //Length: 27
	}

	[Token(Token = "0x17000089")]
	public private override Script OwnerScript
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60004AD")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60004AE")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000088")]
	public CoroutineState State
	{
		[Address(RVA = "0x2F8410", Offset = "0x2F7610", Length = "0x3A")]
		[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<InvokeEvent>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<RunScriptInstance>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "ResumeScriptCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string), "System.Object[]"}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(Script), Member = "RecycleCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Coroutine), typeof(DynValue)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(CoroutineModule), Member = "running", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CalledBy(Type = typeof(CoroutineModule), Member = "status", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004AB")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000087")]
	public private CoroutineType Type
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600049B")]
		 get { } //Length: 4
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600049C")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2F82B0", Offset = "0x2F74B0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600049D")]
	internal Coroutine(CallbackFunction function) { }

	[Address(RVA = "0x2F8340", Offset = "0x2F7540", Length = "0xA6")]
	[CalledBy(Type = typeof(Processor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(Table), typeof(ByteCode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Processor), Member = "Coroutine_Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Closure)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Processor), Member = "Coroutine_Recycle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Processor), typeof(Closure)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600049E")]
	internal Coroutine(Processor proc) { }

	[Address(RVA = "0x2F79E0", Offset = "0x2F6BE0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[IteratorStateMachine(typeof(<AsEnumerable>d__12))]
	[Token(Token = "0x60004A2")]
	public IEnumerable<Object> AsEnumerable() { }

	[Address(RVA = "0x68E6C0", Offset = "0x68D8C0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[IteratorStateMachine(typeof(<AsEnumerable>d__13`1))]
	[Token(Token = "0x60004A3")]
	public IEnumerable<T> AsEnumerable() { }

	[Address(RVA = "0x2F7A60", Offset = "0x2F6C60", Length = "0x71")]
	[CalledBy(Type = typeof(<AsEnumerable>d__12), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<AsEnumerable>d__13`1), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<AsUnityCoroutine>d__14), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[IteratorStateMachine(typeof(<AsTypedEnumerable>d__11))]
	[Token(Token = "0x60004A1")]
	public IEnumerable<DynValue> AsTypedEnumerable() { }

	[Address(RVA = "0x2F7AE0", Offset = "0x2F6CE0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<AsUnityCoroutine>d__14))]
	[Token(Token = "0x60004A4")]
	public IEnumerator AsUnityCoroutine() { }

	[Address(RVA = "0x2F83F0", Offset = "0x2F75F0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004AF")]
	public long get_AutoYieldCounter() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60004AD")]
	public override Script get_OwnerScript() { }

	[Address(RVA = "0x2F8410", Offset = "0x2F7610", Length = "0x3A")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<InvokeEvent>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<RunScriptInstance>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "ResumeScriptCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string), "System.Object[]"}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Script), Member = "RecycleCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Coroutine), typeof(DynValue)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(CoroutineModule), Member = "running", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(CoroutineModule), Member = "status", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004AB")]
	public CoroutineState get_State() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600049B")]
	public CoroutineType get_Type() { }

	[Address(RVA = "0x2F7B50", Offset = "0x2F6D50", Length = "0xB5")]
	[CalledBy(Type = typeof(BasicModule), Member = "error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DebugModule), Member = "traceback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Processor), Member = "GetCoroutineSuspendedLocation", ReturnType = typeof(SourceRef))]
	[Calls(Type = typeof(Processor), Member = "Debugger_GetCallStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SourceRef)}, ReturnType = typeof(System.Collections.Generic.List`1<MoonSharp.Interpreter.Debugging.WatchItem>))]
	[Calls(Type = typeof(Enumerable), Member = "Skip", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", typeof(int)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004AC")]
	public WatchItem[] GetStackTrace(int skip, SourceRef entrySourceRef = null) { }

	[Address(RVA = "0x2F7C10", Offset = "0x2F6E10", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600049F")]
	internal void MarkClrCallbackAsDead() { }

	[Address(RVA = "0x2F7C80", Offset = "0x2F6E80", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Processor), Member = "Coroutine_Recycle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Processor), typeof(Closure)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004A0")]
	internal DynValue Recycle(Processor mainProcessor, Closure closure) { }

	[Address(RVA = "0x2F7D90", Offset = "0x2F6F90", Length = "0x148")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Coroutine), Member = "Resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60004AA")]
	public DynValue Resume(ScriptExecutionContext context, Object[] args) { }

	[Address(RVA = "0x2F7CB0", Offset = "0x2F6EB0", Length = "0x8A")]
	[CalledBy(Type = typeof(<AsTypedEnumerable>d__11), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Coroutine), Member = "Resume", ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(CoroutineModule), Member = "__wrap_wrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(CoroutineModule), Member = "resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(DynValue[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Processor), Member = "Coroutine_Resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004A5")]
	public DynValue Resume(DynValue[] args) { }

	[Address(RVA = "0x2F8250", Offset = "0x2F7450", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Coroutine), Member = "Resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x60004A8")]
	public DynValue Resume(ScriptExecutionContext context) { }

	[Address(RVA = "0x2F7D40", Offset = "0x2F6F40", Length = "0x46")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "ResumeScriptCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string), "System.Object[]"}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Coroutine), Member = "Resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Token(Token = "0x60004A7")]
	public DynValue Resume() { }

	[Address(RVA = "0x2F80D0", Offset = "0x2F72D0", Length = "0x17F")]
	[CalledBy(Type = typeof(Coroutine), Member = "Resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(Coroutine), Member = "Resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptExecutionContext), typeof(Object[])}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(IScriptPrivateResource)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(DynValue[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CallbackArguments), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<MoonSharp.Interpreter.DynValue>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Processor), Member = "Coroutine_Resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ScriptRuntimeException), Member = "CannotResumeNotSuspended", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CoroutineState)}, ReturnType = typeof(ScriptRuntimeException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004A6")]
	public DynValue Resume(ScriptExecutionContext context, DynValue[] args) { }

	[Address(RVA = "0x2F7EE0", Offset = "0x2F70E0", Length = "0x1E7")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "ResumeScriptCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string), "System.Object[]"}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Processor), Member = "Coroutine_Resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ClrToScriptConversions), Member = "ObjectToDynValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScriptPrivateResource_Extension), Member = "CheckScriptOwnership", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IScriptPrivateResource), typeof(DynValue[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60004A9")]
	public DynValue Resume(Object[] args) { }

	[Address(RVA = "0x2F8450", Offset = "0x2F7650", Length = "0x1B")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<InvokeEvent>d__21", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService+<RunScriptInstance>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004B0")]
	public void set_AutoYieldCounter(long value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60004AE")]
	private void set_OwnerScript(Script value) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600049C")]
	private void set_Type(CoroutineType value) { }

}

