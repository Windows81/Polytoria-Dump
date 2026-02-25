namespace Polytoria.Controllers;

[Token(Token = "0x20003FA")]
public class GameIO : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20003FB")]
	private sealed class <>c
	{
		[Token(Token = "0x40010B0")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40010B1")]
		public static Func<PropertyInfo, Boolean> <>9__25_0; //Field offset: 0x8

		[Address(RVA = "0x4CF470", Offset = "0x4CE670", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002AE1")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AE2")]
		public <>c() { }

		[Address(RVA = "0x4CF290", Offset = "0x4CE490", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002AE3")]
		internal bool <SaveHandleChild>b__25_0(PropertyInfo prop) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20003FC")]
	private sealed class <LoadFromSite>d__13 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40010B2")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40010B3")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40010B4")]
		public int id; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40010B5")]
		public GameIO <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40010B6")]
		public Action<Boolean> callback; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40010B7")]
		private UnityWebRequest <uwr>5__2; //Field offset: 0x38

		[Token(Token = "0x17000CD4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AE8")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000CD5")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AEA")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AE4")]
		public <LoadFromSite>d__13(int <>1__state) { }

		[Address(RVA = "0x4CA9A0", Offset = "0x4C9BA0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6002AE7")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x4CA340", Offset = "0x4C9540", Length = "0x580")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Resources), Member = "UnloadUnusedAssets", ReturnType = typeof(AsyncOperation))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(GameIO), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(Instance)}, ReturnType = typeof(Instance))]
		[Calls(Type = typeof(XmlObject), Member = "get_Root", ReturnType = typeof(XmlNode))]
		[Calls(Type = typeof(XmlParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlObject))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(LaunchController), Member = "GetActiveToken", ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6770")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6002AE6")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AE8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AEA")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4CA8D0", Offset = "0x4C9AD0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002AE9")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x4CA910", Offset = "0x4C9B10", Length = "0x8C")]
		[CalledBy(Type = typeof(Vector3ValueProxy), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6570")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[Token(Token = "0x6002AE5")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20003FD")]
	private sealed class <ModelFromSite>d__12 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40010B8")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40010B9")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40010BA")]
		public int id; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40010BB")]
		public GameIO <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40010BC")]
		public Instance parent; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40010BD")]
		public Action<Instance> callback; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40010BE")]
		private UnityWebRequest <uwr>5__2; //Field offset: 0x40

		[Token(Token = "0x17000CD6")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AEF")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000CD7")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AF1")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AEB")]
		public <ModelFromSite>d__12(int <>1__state) { }

		[Address(RVA = "0x4CC820", Offset = "0x4CBA20", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6002AEE")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x4CC340", Offset = "0x4CB540", Length = "0x40C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(GameIO), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(Instance)}, ReturnType = typeof(Instance))]
		[Calls(Type = typeof(XmlObject), Member = "get_Root", ReturnType = typeof(XmlNode))]
		[Calls(Type = typeof(XmlParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlObject))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(LaunchController), Member = "GetActiveToken", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6630")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002AED")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AEF")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AF1")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4CC750", Offset = "0x4CB950", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002AF0")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x4CC790", Offset = "0x4CB990", Length = "0x8C")]
		[CalledBy(Type = typeof(Vector3ValueProxy), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6780")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[Token(Token = "0x6002AEC")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20003FE")]
	private sealed class <PostClearDatamodel>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40010BF")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40010C0")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40010C1")]
		public GameIO <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000CD8")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AF5")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000CD9")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002AF7")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AF2")]
		public <PostClearDatamodel>d__10(int <>1__state) { }

		[Address(RVA = "0x4CCC40", Offset = "0x4CBE40", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(GameIO), Member = "PostMapLoad", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002AF4")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AF5")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AF7")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4CCCE0", Offset = "0x4CBEE0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002AF6")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002AF3")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x40010AE")]
	public static GameIO singleton; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010AD")]
	private Game game; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40010AF")]
	private List<Instance> spawnInstances; //Field offset: 0x28

	[Address(RVA = "0x4C12A0", Offset = "0x4C04A0", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002AE0")]
	public GameIO() { }

	[Address(RVA = "0x4B95B0", Offset = "0x4B87B0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Token(Token = "0x6002AC0")]
	private void Awake() { }

	[Address(RVA = "0x4B9630", Offset = "0x4B8830", Length = "0x12D")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<LoadMapFromFile>d__87", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CreatorController), Member = "ClearWorkspace", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "GetChildren", ReturnType = typeof(Instance[]))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002AC6")]
	public void ClearDatamodel() { }

	[Address(RVA = "0x4B9760", Offset = "0x4B8960", Length = "0x3767")]
	[CalledBy(Type = typeof(GameIO), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(Instance)}, ReturnType = typeof(Instance))]
	[CalledBy(Type = typeof(GameIO), Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), typeof(Instance)}, ReturnType = typeof(Instance))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameIO), Member = "XmlConvertVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GameIO), Member = "XmlConvertColorRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(ColorRange))]
	[Calls(Type = typeof(GameIO), Member = "XmlConvertNumberRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(NumberRange))]
	[Calls(Type = typeof(HttpUtility), Member = "HtmlDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PropertyInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6940")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Instance), Member = "FindChildByClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(GameIO), Member = "XmlConvertColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Instance), Member = "set_Parent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Instance), Member = "IsDescendantOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(GameIO), Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), typeof(Instance)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(Instance), Member = "set_Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameIO), Member = "XmlConvertVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B67E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlNodeList), Member = "GetEnumerator", ReturnType = typeof(Enumerator))]
	[Calls(Type = "U8Xml.XmlNode_", Member = "get_NodeType", ReturnType = typeof(XmlNodeType))]
	[Calls(Type = typeof(XmlNode), Member = "get_Name", ReturnType = typeof(RawString))]
	[Calls(Type = typeof(RawString), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(RawString), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "get_Children", ReturnType = typeof(XmlNodeList))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6A40")]
	[Calls(Type = typeof(XmlAttribute), Member = "get_Value", ReturnType = typeof(RawString&))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(RawString))]
	[Calls(Type = typeof(Part), Member = "set_Shape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartShape)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CustomAttributeExtensions), Member = "GetCustomAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(Type)}, ReturnType = typeof(Attribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 88)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002ACC")]
	private Instance HandleXmlNodes(XmlNodeList nodes, Instance parent) { }

	[Address(RVA = "0x4BD4F0", Offset = "0x4BC6F0", Length = "0x10F")]
	[CalledBy(Type = typeof(Game), Member = "OnStartServer", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<>c__DisplayClass68_0", Member = "<LoadStarterPlaces>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<>c__DisplayClass68_1", Member = "<LoadStarterPlaces>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<CheckToken>d__50", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002AC1")]
	public void Load(int id, Action<Boolean> callback = null) { }

	[Address(RVA = "0x4BCED0", Offset = "0x4BC0D0", Length = "0x142")]
	[CalledBy(Type = typeof(Game), Member = "OnStartServer", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<LoadMapFromFile>d__87", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(XmlParser), Member = "ParseFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlObject))]
	[Calls(Type = typeof(XmlObject), Member = "get_Root", ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(GameIO), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(Instance)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Resources), Member = "UnloadUnusedAssets", ReturnType = typeof(AsyncOperation))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002AC2")]
	public void LoadFromFile(string path, Action<Boolean> callback = null) { }

	[Address(RVA = "0x4BD020", Offset = "0x4BC220", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<LoadFromSite>d__13))]
	[Token(Token = "0x6002ACA")]
	public IEnumerator LoadFromSite(int id, Action<Boolean> callback = null) { }

	[Address(RVA = "0x4BD0C0", Offset = "0x4BC2C0", Length = "0xE8")]
	[CalledBy(Type = typeof(CreatorController), Member = "DoImportModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlParser), Member = "ParseFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlObject))]
	[Calls(Type = typeof(XmlObject), Member = "get_Root", ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(GameIO), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(Instance)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6002AC3")]
	public Instance LoadModelFromFile(string path, Instance parent) { }

	[Address(RVA = "0x4BD1B0", Offset = "0x4BC3B0", Length = "0xBE")]
	[CalledBy(Type = typeof(InsertService), Member = "Model", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ToolboxController), Member = "InsertModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002AC4")]
	public void LoadModelFromSite(int id, Instance parent, Action<Instance> callback = null) { }

	[Address(RVA = "0x4BD270", Offset = "0x4BC470", Length = "0x188")]
	[CalledBy(Type = typeof(ClipboardController), Member = "PasteInstancesFromClipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlObject))]
	[Calls(Type = typeof(XmlObject), Member = "get_Root", ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(GameIO), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(Instance)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6002AC5")]
	public Model LoadModelFromXmlString(string xmlString, Instance parent) { }

	[Address(RVA = "0x4BD400", Offset = "0x4BC600", Length = "0xE2")]
	[CalledBy(Type = typeof(<LoadFromSite>d__13), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<ModelFromSite>d__12), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GameIO), Member = "LoadFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameIO), Member = "LoadModelFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance)}, ReturnType = typeof(Instance))]
	[CalledBy(Type = typeof(GameIO), Member = "LoadModelFromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance)}, ReturnType = typeof(Model))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlNode), Member = "get_Children", ReturnType = typeof(XmlNodeList))]
	[Calls(Type = typeof(GameIO), Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), typeof(Instance)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(GameIO), Member = "PostMapLoad", ReturnType = typeof(void))]
	[Token(Token = "0x6002ACB")]
	private Instance LoadXml(XmlNode xml, Instance parent = null) { }

	[Address(RVA = "0x4BD600", Offset = "0x4BC800", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<ModelFromSite>d__12))]
	[Token(Token = "0x6002AC9")]
	public IEnumerator ModelFromSite(int id, Instance parent, Action<Instance> callback) { }

	[Address(RVA = "0x4BD6C0", Offset = "0x4BC8C0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<PostClearDatamodel>d__10))]
	[Token(Token = "0x6002AC7")]
	private IEnumerator PostClearDatamodel() { }

	[Address(RVA = "0x4BD730", Offset = "0x4BC930", Length = "0xB59")]
	[CalledBy(Type = typeof(<PostClearDatamodel>d__10), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GameIO), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(Instance)}, ReturnType = typeof(Instance))]
	[CalledBy(Type = typeof(CreatorController), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Game), Member = "InvokeLoaded", ReturnType = typeof(void))]
	[Calls(Type = typeof(Game), Member = "BuildNavMesh", ReturnType = typeof(void))]
	[Calls(Type = typeof(Resources), Member = "UnloadUnusedAssets", ReturnType = typeof(AsyncOperation))]
	[Calls(Type = typeof(ScriptService), Member = "RunScripts", ReturnType = typeof(void))]
	[Calls(Type = typeof(Instance), Member = "FindChildOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Player), Member = "Respawn", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "FindObjectsByType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FindObjectsSortMode)}, ReturnType = "T[]")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Instance), Member = "set_Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = "FindChildByClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkServer), Member = "Spawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Token(Token = "0x6002AC8")]
	public void PostMapLoad() { }

	[Address(RVA = "0x4BE290", Offset = "0x4BD490", Length = "0x148")]
	[CalledBy(Type = typeof(GameIO), Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(Instance), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6002ADA")]
	private void SaveBool(XmlDocument doc, XmlElement properties, string name, bool value) { }

	[Address(RVA = "0x4BE600", Offset = "0x4BD800", Length = "0x335")]
	[CalledBy(Type = typeof(GameIO), Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(Instance), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameIO), Member = "SaveColorRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(ColorRange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 11)]
	[Token(Token = "0x6002ADD")]
	private void SaveColor(XmlDocument doc, XmlElement properties, string name, Color value) { }

	[Address(RVA = "0x4BE3E0", Offset = "0x4BD5E0", Length = "0x217")]
	[CalledBy(Type = typeof(GameIO), Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(Instance), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(GameIO), Member = "SaveColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6002ADE")]
	private void SaveColorRange(XmlDocument doc, XmlElement properties, string name, ColorRange value) { }

	[Address(RVA = "0x4BE940", Offset = "0x4BDB40", Length = "0x16E")]
	[CalledBy(Type = typeof(GameIO), Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(Instance), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameIO), Member = "SaveNumberRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(NumberRange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6002AD8")]
	private void SaveFloat(XmlDocument doc, XmlElement properties, string name, float value) { }

	[Address(RVA = "0x4BEAB0", Offset = "0x4BDCB0", Length = "0xD17")]
	[CalledBy(Type = typeof(GameIO), Member = "SaveModelToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(GameIO), Member = "SaveModelToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameIO), Member = "SaveToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(GameIO), Member = "SaveToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GameIO), Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(Instance), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(GameIO), Member = "SaveColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameIO), Member = "SaveVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameIO), Member = "SaveVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameIO), Member = "SaveBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameIO), Member = "SaveInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameIO), Member = "SaveFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameIO), Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(Instance), typeof(XmlElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(Instance), Member = "GetChildren", ReturnType = typeof(Instance[]))]
	[Calls(Type = typeof(GameIO), Member = "SaveColorRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(ColorRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GameIO), Member = "SaveString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameIO), Member = "SaveNumberRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(NumberRange)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetProperties", ReturnType = typeof(PropertyInfo[]))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 25)]
	[Token(Token = "0x6002AD6")]
	private void SaveHandleChild(XmlDocument doc, Instance i, XmlElement parent) { }

	[Address(RVA = "0x4BF7D0", Offset = "0x4BE9D0", Length = "0x12B")]
	[CalledBy(Type = typeof(GameIO), Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(Instance), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6002AD9")]
	private void SaveInt(XmlDocument doc, XmlElement properties, string name, int value) { }

	[Address(RVA = "0x4BF900", Offset = "0x4BEB00", Length = "0x183")]
	[CalledBy(Type = typeof(CreatorController), Member = "DoExportModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(GameIO), Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(Instance), typeof(XmlElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6002AD3")]
	public void SaveModelToFile(Instance root, string path) { }

	[Address(RVA = "0x4BFA90", Offset = "0x4BEC90", Length = "0x306")]
	[CalledBy(Type = typeof(ClipboardController), Member = "CopyInstancesToClipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<DoPublishModel>d__62", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(GameIO), Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(Instance), typeof(XmlElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6002AD2")]
	public string SaveModelToString(Instance root) { }

	[Address(RVA = "0x4BFDA0", Offset = "0x4BEFA0", Length = "0x1DD")]
	[CalledBy(Type = typeof(GameIO), Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(Instance), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(GameIO), Member = "SaveFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6002ADF")]
	private void SaveNumberRange(XmlDocument doc, XmlElement properties, string name, NumberRange value) { }

	[Address(RVA = "0x4BFF80", Offset = "0x4BF180", Length = "0x11C")]
	[CalledBy(Type = typeof(GameIO), Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(Instance), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6002AD7")]
	private void SaveString(XmlDocument doc, XmlElement properties, string name, string value) { }

	[Address(RVA = "0x4C00A0", Offset = "0x4BF2A0", Length = "0x231")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<AutoSaveLoop>d__85", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CreatorController), Member = "TestGame", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "FileSave", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "DoSaveFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_version", ReturnType = typeof(string))]
	[Calls(Type = typeof(Instance), Member = "GetChildren", ReturnType = typeof(Instance[]))]
	[Calls(Type = typeof(GameIO), Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(Instance), typeof(XmlElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6002AD5")]
	public void SaveToFile(string path) { }

	[Address(RVA = "0x4C02E0", Offset = "0x4BF4E0", Length = "0x36D")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<PublishLevelToID>d__81", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Instance), Member = "GetChildren", ReturnType = typeof(Instance[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(GameIO), Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(Instance), typeof(XmlElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6002AD4")]
	public string SaveToString() { }

	[Address(RVA = "0x4C0650", Offset = "0x4BF850", Length = "0x238")]
	[CalledBy(Type = typeof(GameIO), Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(Instance), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6002ADC")]
	private void SaveVector2(XmlDocument doc, XmlElement properties, string name, Vector2 value) { }

	[Address(RVA = "0x4C0890", Offset = "0x4BFA90", Length = "0x2AF")]
	[CalledBy(Type = typeof(GameIO), Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(Instance), typeof(XmlElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlElement))]
	[Calls(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x6002ADB")]
	private void SaveVector3(XmlDocument doc, XmlElement properties, string name, Vector3 value) { }

	[Address(RVA = "0x4C0C60", Offset = "0x4BFE60", Length = "0x224")]
	[CalledBy(Type = typeof(GameIO), Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), typeof(Instance)}, ReturnType = typeof(Instance))]
	[CalledBy(Type = typeof(GameIO), Member = "XmlConvertColorRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(ColorRange))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlNode), Member = "get_Name", ReturnType = typeof(RawString))]
	[Calls(Type = typeof(RawString), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RawString), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6C00")]
	[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(RawString))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B67E0")]
	[Calls(Type = typeof(RawString), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(ColorUtility), Member = "TryParseHtmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002ACF")]
	public Color XmlConvertColor(XmlNode property) { }

	[Address(RVA = "0x4C0B40", Offset = "0x4BFD40", Length = "0x112")]
	[CalledBy(Type = typeof(GameIO), Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), typeof(Instance)}, ReturnType = typeof(Instance))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6C00")]
	[Calls(Type = typeof(GameIO), Member = "XmlConvertColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(ColorRange), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002AD0")]
	public ColorRange XmlConvertColorRange(XmlNode property) { }

	[Address(RVA = "0x4C0E90", Offset = "0x4C0090", Length = "0x11E")]
	[CalledBy(Type = typeof(GameIO), Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), typeof(Instance)}, ReturnType = typeof(Instance))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6C00")]
	[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(RawString))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B67E0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002AD1")]
	public NumberRange XmlConvertNumberRange(XmlNode property) { }

	[Address(RVA = "0x4C0FB0", Offset = "0x4C01B0", Length = "0x133")]
	[CalledBy(Type = typeof(GameIO), Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), typeof(Instance)}, ReturnType = typeof(Instance))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6C00")]
	[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(RawString))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B67E0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002ACE")]
	public Vector2 XmlConvertVector2(XmlNode property) { }

	[Address(RVA = "0x4C10F0", Offset = "0x4C02F0", Length = "0x1A8")]
	[CalledBy(Type = typeof(GameIO), Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeList), typeof(Instance)}, ReturnType = typeof(Instance))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6C00")]
	[Calls(Type = typeof(XmlNode), Member = "get_InnerText", ReturnType = typeof(RawString))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B67E0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002ACD")]
	public Vector3 XmlConvertVector3(XmlNode property) { }

}

