namespace RLD;

[Token(Token = "0x2000148")]
public class RTFocusCamera : MonoSingleton<RTFocusCamera>
{
	[CompilerGenerated]
	[Token(Token = "0x200014A")]
	private sealed class <DoConstantFocus>d__134 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005F0")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005F1")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40005F2")]
		public RTFocusCamera <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40005F3")]
		public Data focusData; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40005F4")]
		private float <targetOrthoSize>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40005F5")]
		private Vector3 <camMoveDir>5__3; //Field offset: 0x34
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40005F6")]
		private float <distanceToTravel>5__4; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40005F7")]
		private float <initialCamOrthoSize>5__5; //Field offset: 0x44

		[Token(Token = "0x1700052C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F3D")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700052D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F3F")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F3A")]
		public <DoConstantFocus>d__134(int <>1__state) { }

		[Address(RVA = "0x54CD50", Offset = "0x54BF50", Length = "0x532")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Camera), Member = "get_fieldOfView", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028EDD0")]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
		[Calls(Type = typeof(Camera), Member = "get_orthographicSize", ReturnType = typeof(float))]
		[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Camera), Member = "set_orthographicSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000F3C")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F3D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F3F")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x54D290", Offset = "0x54C490", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000F3E")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F3B")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200014B")]
	private sealed class <DoConstantRotationSwitch>d__132 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005F8")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005F9")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40005FA")]
		public RTFocusCamera <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40005FB")]
		public Quaternion targetRotation; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40005FC")]
		private Quaternion <sourceRotation>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40005FD")]
		private float <elapsedTime>5__3; //Field offset: 0x48

		[Token(Token = "0x1700052E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F43")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700052F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F45")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F40")]
		public <DoConstantRotationSwitch>d__132(int <>1__state) { }

		[Address(RVA = "0x54D2D0", Offset = "0x54C4D0", Length = "0x22A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Quaternion), Member = "Slerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion), typeof(float)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000F42")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F43")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F45")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x54D500", Offset = "0x54C700", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000F44")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F41")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200014C")]
	private sealed class <DoSmoothFocus>d__135 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40005FE")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40005FF")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000600")]
		public RTFocusCamera <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000601")]
		public Data focusData; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000602")]
		private float <targetOrthoSize>5__2; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000603")]
		private Vector3 <camMoveDir>5__3; //Field offset: 0x34
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000604")]
		private float <elapsedTime>5__4; //Field offset: 0x40

		[Token(Token = "0x17000530")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F49")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000531")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F4B")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F46")]
		public <DoSmoothFocus>d__135(int <>1__state) { }

		[Address(RVA = "0x54D540", Offset = "0x54C740", Length = "0x48E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Camera), Member = "get_fieldOfView", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028EDD0")]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Camera), Member = "get_orthographicSize", ReturnType = typeof(float))]
		[Calls(Type = typeof(Camera), Member = "set_orthographicSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000F48")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F49")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F4B")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x54D9D0", Offset = "0x54CBD0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000F4A")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F47")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200014D")]
	private sealed class <DoSmoothLookAround>d__129 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000605")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000606")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000607")]
		public RTFocusCamera <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000608")]
		public float deviceAxisX; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000609")]
		public float deviceAxisY; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400060A")]
		private Vector2 <rotationAmount>5__2; //Field offset: 0x30

		[Token(Token = "0x17000532")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F4F")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000533")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F51")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F4C")]
		public <DoSmoothLookAround>d__129(int <>1__state) { }

		[Address(RVA = "0x54DA10", Offset = "0x54CC10", Length = "0x1C1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RTFocusCamera), Member = "CalculateLookAroundRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(RTFocusCamera), Member = "LookAround", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000F4E")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F4F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F51")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x54DBE0", Offset = "0x54CDE0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000F50")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F4D")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200014E")]
	private sealed class <DoSmoothOrbit>d__130 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400060B")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400060C")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400060D")]
		public RTFocusCamera <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400060E")]
		public float deviceAxisX; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400060F")]
		public float deviceAxisY; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000610")]
		private Vector2 <rotationAmount>5__2; //Field offset: 0x30

		[Token(Token = "0x17000534")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F55")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000535")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F57")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F52")]
		public <DoSmoothOrbit>d__130(int <>1__state) { }

		[Address(RVA = "0x54DC20", Offset = "0x54CE20", Length = "0x1C1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RTFocusCamera), Member = "CalculateOrbitRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(RTFocusCamera), Member = "Orbit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000F54")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F55")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F57")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x54DDF0", Offset = "0x54CFF0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000F56")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F53")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200014F")]
	private sealed class <DoSmoothPan>d__128 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000611")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000612")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000613")]
		public RTFocusCamera <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000614")]
		public float deviceAxisX; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000615")]
		public float deviceAxisY; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000616")]
		private Vector2 <panAmount>5__2; //Field offset: 0x30

		[Token(Token = "0x17000536")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F5B")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000537")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F5D")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F58")]
		public <DoSmoothPan>d__128(int <>1__state) { }

		[Address(RVA = "0x54DE30", Offset = "0x54D030", Length = "0x1C9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RTFocusCamera), Member = "CalculatePanAmount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(RTFocusCamera), Member = "Pan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000F5A")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F5B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F5D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x54E000", Offset = "0x54D200", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000F5C")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F59")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000150")]
	private sealed class <DoSmoothRotationSwitch>d__133 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000617")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000618")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000619")]
		public RTFocusCamera <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400061A")]
		public Quaternion targetRotation; //Field offset: 0x28

		[Token(Token = "0x17000538")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F61")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000539")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F63")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F5E")]
		public <DoSmoothRotationSwitch>d__133(int <>1__state) { }

		[Address(RVA = "0x54E040", Offset = "0x54D240", Length = "0x203")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(Quaternion), Member = "Slerp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Quaternion), typeof(float)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000F60")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F61")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F63")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x54E250", Offset = "0x54D450", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000F62")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F5F")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000151")]
	private sealed class <DoSmoothZoom>d__131 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400061B")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400061C")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400061D")]
		public RTFocusCamera <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400061E")]
		public float deviceScroll; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400061F")]
		private float <zoomAmount>5__2; //Field offset: 0x2C

		[Token(Token = "0x1700053A")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F67")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700053B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F69")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F64")]
		public <DoSmoothZoom>d__131(int <>1__state) { }

		[Address(RVA = "0x54E290", Offset = "0x54D490", Length = "0x13A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RTFocusCamera), Member = "CalculateScrollZoomAmount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(RTFocusCamera), Member = "Zoom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AF610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000F66")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F67")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F69")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x54E3D0", Offset = "0x54D5D0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000F68")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F65")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000149")]
	private enum MoveDirection
	{
		Left = 0,
		Right = 1,
		Up = 2,
		Down = 3,
		Forward = 4,
		Backwards = 5,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005CB")]
	private CameraProjectionSwitchBeginHandler PrjSwitchTransitionBegin; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005CC")]
	private CameraProjectionSwitchUpdateHandler PrjSwitchTransitionUpdate; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005CD")]
	private CameraProjectionSwitchBeginHandler PrjSwitchTransitionEnd; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005CE")]
	private CameraCanProcessInputHandler CanProcessInput; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005CF")]
	private CameraCanUseScrollWheelHandler CanUseScrollWheel; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40005D0")]
	private Camera _targetCamera; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40005D1")]
	private Transform _targetTransform; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40005D2")]
	private float _fieldOfView; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40005D3")]
	private WorldTransformSnapshot _worldTransformSnapshot; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40005D4")]
	private CameraPrjSwitchTransition _prjSwitchTranstion; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40005D5")]
	private bool _isDoingFocus; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40005D6")]
	private IEnumerator _focusCrtn; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40005D7")]
	private bool _isDoingRotationSwitch; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40005D8")]
	private IEnumerator _genricCamTransformCrtn; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40005D9")]
	private bool _isObjectVisibilityDirty; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40005DA")]
	private List<GameObject> _visibleObjects; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40005DB")]
	private float _focusPointOffset; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40005DC")]
	private Vector3 _lastFocusPoint; //Field offset: 0xA4
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40005DD")]
	private Boolean[] _moveDirFlags; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40005DE")]
	private float _currentAcceleration; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x40005DF")]
	private CameraSettings _settings; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x40005E0")]
	private CameraMoveSettings _moveSettings; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	[Token(Token = "0x40005E1")]
	private CameraPanSettings _panSettings; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x40005E2")]
	private CameraLookAroundSettings _lookAroundSettings; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Token(Token = "0x40005E3")]
	private CameraOrbitSettings _orbitSettings; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x40005E4")]
	private CameraZoomSettings _zoomSettings; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x40005E5")]
	private CameraFocusSettings _focusSettings; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x40005E6")]
	private CameraRotationSwitchSettings _rotationSwitchSettings; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x40005E7")]
	private CameraProjectionSwitchSettings _projectionSwitchSettings; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x40005E8")]
	private CameraHotkeys _hotkeys; //Field offset: 0x108

	[Token(Token = "0x14000020")]
	public event CameraCanProcessInputHandler CanProcessInput
	{
		[Address(RVA = "0x54C2C0", Offset = "0x54B4C0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000EEF")]
		 add { } //Length: 158
		[Address(RVA = "0x54C8C0", Offset = "0x54BAC0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000EF0")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000021")]
	public event CameraCanUseScrollWheelHandler CanUseScrollWheel
	{
		[Address(RVA = "0x54C360", Offset = "0x54B560", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000EF1")]
		 add { } //Length: 158
		[Address(RVA = "0x54C960", Offset = "0x54BB60", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000EF2")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1400001D")]
	public event CameraProjectionSwitchBeginHandler PrjSwitchTransitionBegin
	{
		[Address(RVA = "0x54C400", Offset = "0x54B600", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000EE9")]
		 add { } //Length: 158
		[Address(RVA = "0x54CA00", Offset = "0x54BC00", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000EEA")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1400001F")]
	public event CameraProjectionSwitchBeginHandler PrjSwitchTransitionEnd
	{
		[Address(RVA = "0x54C4A0", Offset = "0x54B6A0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000EED")]
		 add { } //Length: 158
		[Address(RVA = "0x54CAA0", Offset = "0x54BCA0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000EEE")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1400001E")]
	public event CameraProjectionSwitchUpdateHandler PrjSwitchTransitionUpdate
	{
		[Address(RVA = "0x54C540", Offset = "0x54B740", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000EEB")]
		 add { } //Length: 158
		[Address(RVA = "0x54CB40", Offset = "0x54BD40", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000EEC")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000528")]
	public CameraFocusSettings FocusSettings
	{
		[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F0D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700052B")]
	public CameraHotkeys Hotkeys
	{
		[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F10")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000516")]
	public bool IsDoingFocus
	{
		[Address(RVA = "0x521560", Offset = "0x520760", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EF9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000511")]
	public bool IsDoingProjectionSwitch
	{
		[Address(RVA = "0x54C5E0", Offset = "0x54B7E0", Length = "0x1E")]
		[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "OnGUI", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000EF4")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000513")]
	public bool IsDoingRotationSwitch
	{
		[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EF6")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700051D")]
	public bool IsMovingBackwards
	{
		[Address(RVA = "0x54C600", Offset = "0x54B800", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000F02")]
		 get { } //Length: 45
	}

	[Token(Token = "0x17000521")]
	public bool IsMovingDown
	{
		[Address(RVA = "0x54C630", Offset = "0x54B830", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000F06")]
		 get { } //Length: 45
	}

	[Token(Token = "0x1700051C")]
	public bool IsMovingForward
	{
		[Address(RVA = "0x54C660", Offset = "0x54B860", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000F01")]
		 get { } //Length: 45
	}

	[Token(Token = "0x1700051E")]
	public bool IsMovingLeft
	{
		[Address(RVA = "0x54C690", Offset = "0x54B890", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000F03")]
		 get { } //Length: 45
	}

	[Token(Token = "0x1700051F")]
	public bool IsMovingRight
	{
		[Address(RVA = "0x54C6C0", Offset = "0x54B8C0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000F04")]
		 get { } //Length: 45
	}

	[Token(Token = "0x17000520")]
	public bool IsMovingUp
	{
		[Address(RVA = "0x54C6F0", Offset = "0x54B8F0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000F05")]
		 get { } //Length: 45
	}

	[Token(Token = "0x1700051B")]
	public Vector3 Look
	{
		[Address(RVA = "0x54C720", Offset = "0x54B920", Length = "0x3B")]
		[CalledBy(Type = typeof(SceneTree), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(SceneRaycastPrecision), typeof(System.Collections.Generic.List`1<RLD.GameObjectRayHit>)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000F00")]
		 get { } //Length: 59
	}

	[Token(Token = "0x17000525")]
	public CameraLookAroundSettings LookAroundSettings
	{
		[Address(RVA = "0x2DD230", Offset = "0x2DC430", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F0A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000523")]
	public CameraMoveSettings MoveSettings
	{
		[Address(RVA = "0x2DD1A0", Offset = "0x2DC3A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F08")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000526")]
	public CameraOrbitSettings OrbitSettings
	{
		[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F0B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000524")]
	public CameraPanSettings PanSettings
	{
		[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F09")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000515")]
	public float PrjSwitchDurationInSeconds
	{
		[Address(RVA = "0x54C760", Offset = "0x54B960", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000EF8")]
		 get { } //Length: 31
	}

	[Token(Token = "0x17000514")]
	public float PrjSwitchProgress
	{
		[Address(RVA = "0x54C780", Offset = "0x54B980", Length = "0x1C")]
		[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "OnGUI", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000EF7")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000512")]
	public Type PrjSwitchTransitionType
	{
		[Address(RVA = "0x54C7A0", Offset = "0x54B9A0", Length = "0x1A")]
		[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "OnGUI", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000EF5")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700052A")]
	public CameraProjectionSwitchSettings ProjectionSwitchSettings
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F0F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000519")]
	public Vector3 Right
	{
		[Address(RVA = "0x54C7C0", Offset = "0x54B9C0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000EFE")]
		 get { } //Length: 59
	}

	[Token(Token = "0x17000529")]
	public CameraRotationSwitchSettings RotationSwitchSettings
	{
		[Address(RVA = "0x3F58C0", Offset = "0x3F4AC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F0E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000522")]
	public CameraSettings Settings
	{
		[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F07")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000510")]
	public Camera TargetCamera
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000EF3")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700051A")]
	public Vector3 Up
	{
		[Address(RVA = "0x54C800", Offset = "0x54BA00", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000EFF")]
		 get { } //Length: 59
	}

	[Token(Token = "0x17000517")]
	public Vector3 WorldPosition
	{
		[Address(RVA = "0x54C840", Offset = "0x54BA40", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000EFA")]
		 get { } //Length: 59
		[Address(RVA = "0x54CBE0", Offset = "0x54BDE0", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RTFocusCamera), Member = "GetFocusPoint", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000EFB")]
		 set { } //Length: 217
	}

	[Token(Token = "0x17000518")]
	public Quaternion WorldRotation
	{
		[Address(RVA = "0x54C880", Offset = "0x54BA80", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000EFC")]
		 get { } //Length: 51
		[Address(RVA = "0x54CCC0", Offset = "0x54BEC0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000EFD")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000527")]
	public CameraZoomSettings ZoomSettings
	{
		[Address(RVA = "0x2E7250", Offset = "0x2E6450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F0C")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x54BBA0", Offset = "0x54ADA0", Length = "0x715")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CameraHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Token(Token = "0x6000F39")]
	public RTFocusCamera() { }

	[Address(RVA = "0x54C2C0", Offset = "0x54B4C0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000EEF")]
	public void add_CanProcessInput(CameraCanProcessInputHandler value) { }

	[Address(RVA = "0x54C360", Offset = "0x54B560", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000EF1")]
	public void add_CanUseScrollWheel(CameraCanUseScrollWheelHandler value) { }

	[Address(RVA = "0x54C400", Offset = "0x54B600", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000EE9")]
	public void add_PrjSwitchTransitionBegin(CameraProjectionSwitchBeginHandler value) { }

	[Address(RVA = "0x54C4A0", Offset = "0x54B6A0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000EED")]
	public void add_PrjSwitchTransitionEnd(CameraProjectionSwitchBeginHandler value) { }

	[Address(RVA = "0x54C540", Offset = "0x54B740", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000EEB")]
	public void add_PrjSwitchTransitionUpdate(CameraProjectionSwitchUpdateHandler value) { }

	[Address(RVA = "0x548750", Offset = "0x547950", Length = "0xB7")]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "SetTargetCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "Focus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "Zoom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "PerformInstantFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Data)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028EDD0")]
	[Calls(Type = typeof(Camera), Member = "set_orthographicSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F2D")]
	private void AdjustOrthoSizeForFocusPt() { }

	[Address(RVA = "0x548810", Offset = "0x547A10", Length = "0x46A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTFocusCamera), Member = "SetTargetCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Break", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(WorldTransformSnapshot), Member = "Snaphot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000F1A")]
	private void Awake() { }

	[Address(RVA = "0x548C80", Offset = "0x547E80", Length = "0xAB")]
	[CalledBy(Type = typeof(<DoSmoothLookAround>d__129), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F27")]
	private Vector2 CalculateLookAroundRotation(float deviceAxisX, float deviceAxisY) { }

	[Address(RVA = "0x548D30", Offset = "0x547F30", Length = "0xAB")]
	[CalledBy(Type = typeof(<DoSmoothOrbit>d__130), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F28")]
	private Vector2 CalculateOrbitRotation(float deviceAxisX, float deviceAxisY) { }

	[Address(RVA = "0x548DE0", Offset = "0x547FE0", Length = "0x13D")]
	[CalledBy(Type = typeof(<DoSmoothPan>d__128), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "EstimateZoomFactorSpherical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F29")]
	private Vector2 CalculatePanAmount(float deviceAxisX, float deviceAxisY) { }

	[Address(RVA = "0x548F20", Offset = "0x548120", Length = "0x11A")]
	[CalledBy(Type = typeof(<DoSmoothZoom>d__131), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "EstimateZoomFactorSpherical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F21")]
	private float CalculateScrollZoomAmount(float deviceScroll) { }

	[Address(RVA = "0x549040", Offset = "0x548240", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F1E")]
	private bool CanCameraProcessInput() { }

	[Address(RVA = "0x549130", Offset = "0x548330", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F1D")]
	private bool CanUseMouseScrollWheel() { }

	[Address(RVA = "0x5491D0", Offset = "0x5483D0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DoConstantFocus>d__134))]
	[Token(Token = "0x6000F34")]
	private IEnumerator DoConstantFocus(Data focusData) { }

	[Address(RVA = "0x549260", Offset = "0x548460", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DoConstantRotationSwitch>d__132))]
	[Token(Token = "0x6000F32")]
	private IEnumerator DoConstantRotationSwitch(Quaternion targetRotation) { }

	[Address(RVA = "0x5492E0", Offset = "0x5484E0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DoSmoothFocus>d__135))]
	[Token(Token = "0x6000F35")]
	private IEnumerator DoSmoothFocus(Data focusData) { }

	[Address(RVA = "0x549370", Offset = "0x548570", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DoSmoothLookAround>d__129))]
	[Token(Token = "0x6000F2F")]
	private IEnumerator DoSmoothLookAround(float deviceAxisX, float deviceAxisY) { }

	[Address(RVA = "0x549400", Offset = "0x548600", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DoSmoothOrbit>d__130))]
	[Token(Token = "0x6000F30")]
	private IEnumerator DoSmoothOrbit(float deviceAxisX, float deviceAxisY) { }

	[Address(RVA = "0x549490", Offset = "0x548690", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DoSmoothPan>d__128))]
	[Token(Token = "0x6000F2E")]
	private IEnumerator DoSmoothPan(float deviceAxisX, float deviceAxisY) { }

	[Address(RVA = "0x549520", Offset = "0x548720", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DoSmoothRotationSwitch>d__133))]
	[Token(Token = "0x6000F33")]
	private IEnumerator DoSmoothRotationSwitch(Quaternion targetRotation) { }

	[Address(RVA = "0x5495A0", Offset = "0x5487A0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DoSmoothZoom>d__131))]
	[Token(Token = "0x6000F31")]
	private IEnumerator DoSmoothZoom(float deviceScroll) { }

	[Address(RVA = "0x549620", Offset = "0x548820", Length = "0x244")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "DoImportModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "ToolboxModelAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Model)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance), typeof(bool)}, ReturnType = typeof(Instance))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartShape), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddSeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTFocusCamera), Member = "StopCamTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraFocus), Member = "CalculateFocusData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(AABB), typeof(CameraFocusSettings)}, ReturnType = typeof(Data))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTFocusCamera), Member = "AdjustOrthoSizeForFocusPt", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000F18")]
	public void Focus(AABB focusAABB) { }

	[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F0D")]
	public CameraFocusSettings get_FocusSettings() { }

	[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F10")]
	public CameraHotkeys get_Hotkeys() { }

	[Address(RVA = "0x521560", Offset = "0x520760", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EF9")]
	public bool get_IsDoingFocus() { }

	[Address(RVA = "0x54C5E0", Offset = "0x54B7E0", Length = "0x1E")]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "OnGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000EF4")]
	public bool get_IsDoingProjectionSwitch() { }

	[Address(RVA = "0x42CE90", Offset = "0x42C090", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EF6")]
	public bool get_IsDoingRotationSwitch() { }

	[Address(RVA = "0x54C600", Offset = "0x54B800", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F02")]
	public bool get_IsMovingBackwards() { }

	[Address(RVA = "0x54C630", Offset = "0x54B830", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F06")]
	public bool get_IsMovingDown() { }

	[Address(RVA = "0x54C660", Offset = "0x54B860", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F01")]
	public bool get_IsMovingForward() { }

	[Address(RVA = "0x54C690", Offset = "0x54B890", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F03")]
	public bool get_IsMovingLeft() { }

	[Address(RVA = "0x54C6C0", Offset = "0x54B8C0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F04")]
	public bool get_IsMovingRight() { }

	[Address(RVA = "0x54C6F0", Offset = "0x54B8F0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F05")]
	public bool get_IsMovingUp() { }

	[Address(RVA = "0x54C720", Offset = "0x54B920", Length = "0x3B")]
	[CalledBy(Type = typeof(SceneTree), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(SceneRaycastPrecision), typeof(System.Collections.Generic.List`1<RLD.GameObjectRayHit>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F00")]
	public Vector3 get_Look() { }

	[Address(RVA = "0x2DD230", Offset = "0x2DC430", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F0A")]
	public CameraLookAroundSettings get_LookAroundSettings() { }

	[Address(RVA = "0x2DD1A0", Offset = "0x2DC3A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F08")]
	public CameraMoveSettings get_MoveSettings() { }

	[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F0B")]
	public CameraOrbitSettings get_OrbitSettings() { }

	[Address(RVA = "0x2DD1B0", Offset = "0x2DC3B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F09")]
	public CameraPanSettings get_PanSettings() { }

	[Address(RVA = "0x54C760", Offset = "0x54B960", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EF8")]
	public float get_PrjSwitchDurationInSeconds() { }

	[Address(RVA = "0x54C780", Offset = "0x54B980", Length = "0x1C")]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "OnGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EF7")]
	public float get_PrjSwitchProgress() { }

	[Address(RVA = "0x54C7A0", Offset = "0x54B9A0", Length = "0x1A")]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "OnGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EF5")]
	public Type get_PrjSwitchTransitionType() { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F0F")]
	public CameraProjectionSwitchSettings get_ProjectionSwitchSettings() { }

	[Address(RVA = "0x54C7C0", Offset = "0x54B9C0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EFE")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x3F58C0", Offset = "0x3F4AC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F0E")]
	public CameraRotationSwitchSettings get_RotationSwitchSettings() { }

	[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F07")]
	public CameraSettings get_Settings() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000EF3")]
	public Camera get_TargetCamera() { }

	[Address(RVA = "0x54C800", Offset = "0x54BA00", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EFF")]
	public Vector3 get_Up() { }

	[Address(RVA = "0x54C840", Offset = "0x54BA40", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EFA")]
	public Vector3 get_WorldPosition() { }

	[Address(RVA = "0x54C880", Offset = "0x54BA80", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EFC")]
	public Quaternion get_WorldRotation() { }

	[Address(RVA = "0x2E7250", Offset = "0x2E6450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F0C")]
	public CameraZoomSettings get_ZoomSettings() { }

	[Address(RVA = "0x549870", Offset = "0x548A70", Length = "0xB0")]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "set_WorldPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "SetTargetCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "PerformProjectionSwitch", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "Zoom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F20")]
	private Vector3 GetFocusPoint() { }

	[Address(RVA = "0x549930", Offset = "0x548B30", Length = "0x228")]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "GatherDestinationObjects", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformMultiSelect", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CameraViewVolume), Member = "FromCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "GetVisibleObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(CameraViewVolume), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F15")]
	public void GetVisibleObjects(List<GameObject> visibleObjects) { }

	[Address(RVA = "0x549B60", Offset = "0x548D60", Length = "0xC42")]
	[CalledBy(Type = typeof(RLDApp), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "get_orthographicSize", ReturnType = typeof(float))]
	[Calls(Type = typeof(Input), Member = "GetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RTFocusCamera), Member = "StopCamTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTFocusCamera), Member = "CalculatePanAmount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RTFocusCamera), Member = "Pan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTFocusCamera), Member = "Orbit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RTFocusCamera), Member = "CalculateLookAroundRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RTFocusCamera), Member = "LookAround", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTFocusCamera), Member = "CalculateOrbitRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Camera), Member = "get_pixelHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RTFocusCamera), Member = "CalculateScrollZoomAmount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(RTFocusCamera), Member = "Zoom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F1C")]
	private void HandleMouseAndKeyboardInput() { }

	[Address(RVA = "0x54A7B0", Offset = "0x5499B0", Length = "0x19A")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "OnInputDevicePickButtonDown", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "OnInputDevicePickButtonUp", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Camera), Member = "ScreenToViewportPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F11")]
	public bool IsViewportHoveredByDevice() { }

	[Address(RVA = "0x54A950", Offset = "0x549B50", Length = "0xE5")]
	[CalledBy(Type = typeof(<DoSmoothLookAround>d__129), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Transform), Member = "Rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(Space)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F23")]
	public void LookAround(float degreesLocalX, float degreesWorldY) { }

	[Address(RVA = "0x54AA40", Offset = "0x549C40", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F36")]
	private void OnPrjSwitchTransitionBegin(Type transitionType) { }

	[Address(RVA = "0x54AA60", Offset = "0x549C60", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F38")]
	private void OnPrjSwitchTransitionEnd(Type transitionType) { }

	[Address(RVA = "0x54AA80", Offset = "0x549C80", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F37")]
	private void OnPrjSwitchTransitionUpate(Type transitionType) { }

	[Address(RVA = "0x54AAA0", Offset = "0x549CA0", Length = "0x211")]
	[CalledBy(Type = typeof(<DoSmoothOrbit>d__130), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Transform), Member = "RotateAround", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F24")]
	private void Orbit(float degreesLocalX, float degreesWorldY) { }

	[Address(RVA = "0x54ACC0", Offset = "0x549EC0", Length = "0x13B")]
	[CalledBy(Type = typeof(<DoSmoothPan>d__128), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_up", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F22")]
	private void Pan(Vector2 panAmount) { }

	[Address(RVA = "0x54AE00", Offset = "0x54A000", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(RTFocusCamera), Member = "AdjustOrthoSizeForFocusPt", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F25")]
	private void PerformInstantFocus(Data focusData) { }

	[Address(RVA = "0x54AF00", Offset = "0x54A100", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "set_orthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F26")]
	private void PerformInstantProjectionSwitch() { }

	[Address(RVA = "0x54AF40", Offset = "0x54A140", Length = "0x31C")]
	[CalledBy(Type = typeof(SceneGizmoCamPrjSwitchLabel), Member = "OnGizmoHandlePicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoMidCap), Member = "OnGizmoHandlePicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTFocusCamera), Member = "GetFocusPoint", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Camera), Member = "set_orthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000F17")]
	public void PerformProjectionSwitch() { }

	[Address(RVA = "0x54B260", Offset = "0x54A460", Length = "0x178")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "OnGizmoHandlePicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000F16")]
	public void PerformRotationSwitch(Quaternion targetRotation) { }

	[Address(RVA = "0x54C8C0", Offset = "0x54BAC0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000EF0")]
	public void remove_CanProcessInput(CameraCanProcessInputHandler value) { }

	[Address(RVA = "0x54C960", Offset = "0x54BB60", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000EF2")]
	public void remove_CanUseScrollWheel(CameraCanUseScrollWheelHandler value) { }

	[Address(RVA = "0x54CA00", Offset = "0x54BC00", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000EEA")]
	public void remove_PrjSwitchTransitionBegin(CameraProjectionSwitchBeginHandler value) { }

	[Address(RVA = "0x54CAA0", Offset = "0x54BCA0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000EEE")]
	public void remove_PrjSwitchTransitionEnd(CameraProjectionSwitchBeginHandler value) { }

	[Address(RVA = "0x54CB40", Offset = "0x54BD40", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000EEC")]
	public void remove_PrjSwitchTransitionUpdate(CameraProjectionSwitchUpdateHandler value) { }

	[Address(RVA = "0x54CBE0", Offset = "0x54BDE0", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTFocusCamera), Member = "GetFocusPoint", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EFB")]
	public void set_WorldPosition(Vector3 value) { }

	[Address(RVA = "0x54CCC0", Offset = "0x54BEC0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000EFD")]
	public void set_WorldRotation(Quaternion value) { }

	[Address(RVA = "0x54B3E0", Offset = "0x54A5E0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F13")]
	public void SetFieldOfView(float fov) { }

	[Address(RVA = "0x54B420", Offset = "0x54A620", Length = "0x7F")]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "SetTargetCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F2C")]
	private void SetFocusPoint(Vector3 focusPoint) { }

	[Address(RVA = "0x54B4A0", Offset = "0x54A6A0", Length = "0x8")]
	[CalledBy(Type = typeof(RTScene), Member = "OnGameObjectWillBeDestroyed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneTree), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SceneTree), Member = "UnregisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SceneTree), Member = "OnObjectTransformChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Token(Token = "0x6000F14")]
	public void SetObjectVisibilityDirty() { }

	[Address(RVA = "0x54B4B0", Offset = "0x54A6B0", Length = "0x144")]
	[CalledBy(Type = typeof(RTCameraViewports), Member = "SetFocusCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTCameraViewports), Member = "SetFocusCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTFocusCamera), Member = "SetFocusPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTFocusCamera), Member = "GetFocusPoint", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView", ReturnType = typeof(float))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTFocusCamera), Member = "AdjustOrthoSizeForFocusPt", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000F12")]
	public void SetTargetCamera(Camera camera) { }

	[Address(RVA = "0x54B600", Offset = "0x54A800", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(RTFocusCamera), Member = "AdjustOrthoSizeForFocusPt", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F1B")]
	private void Start() { }

	[Address(RVA = "0x54B6E0", Offset = "0x54A8E0", Length = "0x46")]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "Focus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000F2A")]
	private void StopCamTransform() { }

	[Address(RVA = "0x54B730", Offset = "0x54A930", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000F2B")]
	private void StopFocus() { }

	[Address(RVA = "0x54B770", Offset = "0x54A970", Length = "0x17A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTInputDevice), Member = "get_DeviceType", ReturnType = typeof(InputDeviceType))]
	[Calls(Type = typeof(RTFocusCamera), Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
	[Calls(Type = typeof(WorldTransformSnapshot), Member = "SameAs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(WorldTransformSnapshot), Member = "Snaphot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F19")]
	public void Update_SystemCall() { }

	[Address(RVA = "0x54B8F0", Offset = "0x54AAF0", Length = "0x2AD")]
	[CalledBy(Type = typeof(<DoSmoothZoom>d__131), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RTFocusCamera), Member = "GetFocusPoint", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(RTFocusCamera), Member = "AdjustOrthoSizeForFocusPt", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F1F")]
	private void Zoom(float zoomAmount) { }

}

