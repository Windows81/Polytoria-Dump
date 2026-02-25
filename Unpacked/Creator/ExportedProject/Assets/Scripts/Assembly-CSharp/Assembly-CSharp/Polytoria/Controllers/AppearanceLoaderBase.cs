namespace Polytoria.Controllers;

[Token(Token = "0x20003F0")]
public class AppearanceLoaderBase : NetworkBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20003F1")]
	private sealed class <ApplyBodyParts>d__62 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400107E")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400107F")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001080")]
		public AppearanceLoaderBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001081")]
		private GameObject <go>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001082")]
		private GltfImport <gltf>5__3; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4001083")]
		private Task<Boolean> <t>5__4; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4001084")]
		private Task<Boolean> <task>5__5; //Field offset: 0x40

		[Token(Token = "0x17000CCC")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002A89")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000CCD")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002A8B")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A86")]
		public <ApplyBodyParts>d__62(int <>1__state) { }

		[Address(RVA = "0x4C77D0", Offset = "0x4C69D0", Length = "0x61B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
		[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
		[Calls(Type = typeof(Mesh), Member = "set_vertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Mesh), Member = "get_vertices", ReturnType = typeof(Vector3[]))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(MeshFilter), Member = "get_sharedMesh", ReturnType = typeof(Mesh))]
		[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(GltfImportBase), Member = "InstantiateMainSceneAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(GltfImportBase), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ImportSettings), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(GltfImport), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDownloadProvider), typeof(IDeferAgent), typeof(IMaterialGenerator), typeof(ICodeLogger)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "set_localEulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002A88")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A89")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A8B")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4C7DF0", Offset = "0x4C6FF0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002A8A")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A87")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20003F2")]
	private sealed class <ApplyHats>d__60 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001085")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001086")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001087")]
		public AppearanceLoaderBase <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001088")]
		private Enumerator<String> <>7__wrap1; //Field offset: 0x28
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4001089")]
		private string <url>5__3; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400108A")]
		private GameObject <hat>5__4; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400108B")]
		private GltfImport <gltf>5__5; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400108C")]
		private Task<Boolean> <t>5__6; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400108D")]
		private Task<Boolean> <task>5__7; //Field offset: 0x60

		[Token(Token = "0x17000CCE")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002A90")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000CCF")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002A92")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A8C")]
		public <ApplyHats>d__60(int <>1__state) { }

		[Address(RVA = "0x4C8A20", Offset = "0x4C7C20", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002A8F")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x4C7E30", Offset = "0x4C7030", Length = "0xB1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(SyncList`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GltfImportBase), Member = "InstantiateMainSceneAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(GltfImportBase), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ImportSettings), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
		[Calls(Type = typeof(GltfImport), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDownloadProvider), typeof(IDeferAgent), typeof(IMaterialGenerator), typeof(ICodeLogger)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "set_localEulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(SyncList`1), Member = "GetEnumerator", ReturnType = "Mirror.SyncList`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Transform), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6760")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6002A8E")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A90")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A92")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4C8950", Offset = "0x4C7B50", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002A91")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x4C8990", Offset = "0x4C7B90", Length = "0x85")]
		[CalledBy(Type = typeof(Vector3ValueProxy), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6640")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[Token(Token = "0x6002A8D")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20003F3")]
	private sealed class <ProcessAppearance>d__57 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400108E")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400108F")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001090")]
		public int userID; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001091")]
		public AppearanceLoaderBase <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001092")]
		private UnityWebRequest <uwr>5__2; //Field offset: 0x30

		[Token(Token = "0x17000CD0")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002A97")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000CD1")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002A99")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A93")]
		public <ProcessAppearance>d__57(int <>1__state) { }

		[Address(RVA = "0x4CDC40", Offset = "0x4CCE40", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6002A96")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x4CCD20", Offset = "0x4CBF20", Length = "0xE46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(System.Collections.Generic.KeyValuePair`2<System.String, SimpleJSON.JSONNode>))]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.KeyValuePair`2<System.String, SimpleJSON.JSONNode>)}, ReturnType = typeof(JSONNode))]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(ColorUtility), Member = "TryParseHtmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(AppearanceLoaderBase), Member = "ApplyAppearance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AppearanceData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6560")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(LaunchController), Member = "GetActiveToken", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(JSON), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 10)]
		[CallsUnknownMethods(Count = 17)]
		[Token(Token = "0x6002A95")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A97")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A99")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4CDB70", Offset = "0x4CCD70", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002A98")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x4CDBB0", Offset = "0x4CCDB0", Length = "0x8C")]
		[CalledBy(Type = typeof(Vector3ValueProxy), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804B6690")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[Token(Token = "0x6002A94")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x4001063")]
	private static Dictionary<Int32, AppearanceData> playerAppearanceCache; //Field offset: 0x0
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001064")]
	protected Transform headObj; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001065")]
	protected Transform torsoObj; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001066")]
	protected Mesh defaultTorsoMesh; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001067")]
	private int currentlyLoadingUserID; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[SyncVar(hook = "ColorChanged")]
	[Token(Token = "0x4001068")]
	protected Color headColor; //Field offset: 0x84
	[FieldOffset(Offset = "0x94")]
	[SyncVar(hook = "ColorChanged")]
	[Token(Token = "0x4001069")]
	protected Color torsoColor; //Field offset: 0x94
	[FieldOffset(Offset = "0xA4")]
	[SyncVar(hook = "ColorChanged")]
	[Token(Token = "0x400106A")]
	protected Color leftArmColor; //Field offset: 0xA4
	[FieldOffset(Offset = "0xB4")]
	[SyncVar(hook = "ColorChanged")]
	[Token(Token = "0x400106B")]
	protected Color rightArmColor; //Field offset: 0xB4
	[FieldOffset(Offset = "0xC4")]
	[SyncVar(hook = "ColorChanged")]
	[Token(Token = "0x400106C")]
	protected Color leftLegColor; //Field offset: 0xC4
	[FieldOffset(Offset = "0xD4")]
	[SyncVar(hook = "ColorChanged")]
	[Token(Token = "0x400106D")]
	protected Color rightLegColor; //Field offset: 0xD4
	[FieldOffset(Offset = "0xE4")]
	[SyncVar(hook = "ClothingChanged")]
	[Token(Token = "0x400106E")]
	protected int faceID; //Field offset: 0xE4
	[FieldOffset(Offset = "0xE8")]
	[SyncVar(hook = "ClothingChanged")]
	[Token(Token = "0x400106F")]
	protected int shirtID; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[SyncVar(hook = "ClothingChanged")]
	[Token(Token = "0x4001070")]
	protected int pantsID; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[SyncVar]
	[Token(Token = "0x4001071")]
	protected int torsoID; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x4001072")]
	protected readonly SyncList<String> hatUrls; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[SyncVar(hook = "BodyChanged")]
	[Token(Token = "0x4001073")]
	private string torsoUrl; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4001074")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_headColor; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4001075")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_torsoColor; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4001076")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_leftArmColor; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4001077")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_rightArmColor; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4001078")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_leftLegColor; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4001079")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_rightLegColor; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x400107A")]
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_faceID; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400107B")]
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_shirtID; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400107C")]
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_pantsID; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x400107D")]
	public Action<String, String> _Mirror_SyncVarHookDelegate_torsoUrl; //Field offset: 0x150

	[Token(Token = "0x17000CBD")]
	public int FaceID
	{
		[Address(RVA = "0x3D64F0", Offset = "0x3D56F0", Length = "0x7")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A52")]
		 get { } //Length: 7
		[Address(RVA = "0x4A0A00", Offset = "0x49FC00", Length = "0x65")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A53")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000CB7")]
	public Color HeadColor
	{
		[Address(RVA = "0x4A0980", Offset = "0x49FB80", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A46")]
		 get { } //Length: 14
		[Address(RVA = "0x4A0A70", Offset = "0x49FC70", Length = "0x71")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A47")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000CB9")]
	public Color LeftArmColor
	{
		[Address(RVA = "0x4A0990", Offset = "0x49FB90", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A4A")]
		 get { } //Length: 14
		[Address(RVA = "0x4A0AF0", Offset = "0x49FCF0", Length = "0x71")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A4B")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000CBB")]
	public Color LeftLegColor
	{
		[Address(RVA = "0x4A09A0", Offset = "0x49FBA0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A4E")]
		 get { } //Length: 14
		[Address(RVA = "0x4A0B70", Offset = "0x49FD70", Length = "0x71")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A4F")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000CC7")]
	public int NetworkfaceID
	{
		[Address(RVA = "0x3D64F0", Offset = "0x3D56F0", Length = "0x7")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A7A")]
		 get { } //Length: 7
		[Address(RVA = "0x4A0A00", Offset = "0x49FC00", Length = "0x65")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A7B")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000CC1")]
	public Color NetworkheadColor
	{
		[Address(RVA = "0x4A0980", Offset = "0x49FB80", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A6E")]
		 get { } //Length: 14
		[Address(RVA = "0x4A0A70", Offset = "0x49FC70", Length = "0x71")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A6F")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000CC3")]
	public Color NetworkleftArmColor
	{
		[Address(RVA = "0x4A0990", Offset = "0x49FB90", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A72")]
		 get { } //Length: 14
		[Address(RVA = "0x4A0AF0", Offset = "0x49FCF0", Length = "0x71")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A73")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000CC5")]
	public Color NetworkleftLegColor
	{
		[Address(RVA = "0x4A09A0", Offset = "0x49FBA0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A76")]
		 get { } //Length: 14
		[Address(RVA = "0x4A0B70", Offset = "0x49FD70", Length = "0x71")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A77")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000CC9")]
	public int NetworkpantsID
	{
		[Address(RVA = "0x4A09B0", Offset = "0x49FBB0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A7E")]
		 get { } //Length: 7
		[Address(RVA = "0x4A0BF0", Offset = "0x49FDF0", Length = "0x65")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A7F")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000CC4")]
	public Color NetworkrightArmColor
	{
		[Address(RVA = "0x4A09C0", Offset = "0x49FBC0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A74")]
		 get { } //Length: 14
		[Address(RVA = "0x4A0C60", Offset = "0x49FE60", Length = "0x71")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A75")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000CC6")]
	public Color NetworkrightLegColor
	{
		[Address(RVA = "0x4A09D0", Offset = "0x49FBD0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A78")]
		 get { } //Length: 14
		[Address(RVA = "0x4A0CE0", Offset = "0x49FEE0", Length = "0x71")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A79")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000CC8")]
	public int NetworkshirtID
	{
		[Address(RVA = "0x3D6530", Offset = "0x3D5730", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A7C")]
		 get { } //Length: 7
		[Address(RVA = "0x4A0D60", Offset = "0x49FF60", Length = "0x65")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A7D")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000CC2")]
	public Color NetworktorsoColor
	{
		[Address(RVA = "0x4A09E0", Offset = "0x49FBE0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A70")]
		 get { } //Length: 14
		[Address(RVA = "0x4A0DD0", Offset = "0x49FFD0", Length = "0x71")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A71")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000CCA")]
	public int NetworktorsoID
	{
		[Address(RVA = "0x4A09F0", Offset = "0x49FBF0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A80")]
		 get { } //Length: 7
		[Address(RVA = "0x4A0E50", Offset = "0x4A0050", Length = "0xB1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A81")]
		 set { } //Length: 177
	}

	[Token(Token = "0x17000CCB")]
	public string NetworktorsoUrl
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A82")]
		 get { } //Length: 8
		[Address(RVA = "0x4A0F10", Offset = "0x4A0110", Length = "0x13F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&), typeof(ulong)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002A83")]
		 set { } //Length: 319
	}

	[Token(Token = "0x17000CBF")]
	public int PantsID
	{
		[Address(RVA = "0x4A09B0", Offset = "0x49FBB0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A56")]
		 get { } //Length: 7
		[Address(RVA = "0x4A0BF0", Offset = "0x49FDF0", Length = "0x65")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A57")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000CBA")]
	public Color RightArmColor
	{
		[Address(RVA = "0x4A09C0", Offset = "0x49FBC0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A4C")]
		 get { } //Length: 14
		[Address(RVA = "0x4A0C60", Offset = "0x49FE60", Length = "0x71")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A4D")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000CBC")]
	public Color RightLegColor
	{
		[Address(RVA = "0x4A09D0", Offset = "0x49FBD0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A50")]
		 get { } //Length: 14
		[Address(RVA = "0x4A0CE0", Offset = "0x49FEE0", Length = "0x71")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A51")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000CBE")]
	public int ShirtID
	{
		[Address(RVA = "0x3D6530", Offset = "0x3D5730", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A54")]
		 get { } //Length: 7
		[Address(RVA = "0x4A0D60", Offset = "0x49FF60", Length = "0x65")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A55")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000CB8")]
	public Color TorsoColor
	{
		[Address(RVA = "0x4A09E0", Offset = "0x49FBE0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A48")]
		 get { } //Length: 14
		[Address(RVA = "0x4A0DD0", Offset = "0x49FFD0", Length = "0x71")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A49")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000CC0")]
	public int TorsoID
	{
		[Address(RVA = "0x4A09F0", Offset = "0x49FBF0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A58")]
		 get { } //Length: 7
		[Address(RVA = "0x4A0E50", Offset = "0x4A0050", Length = "0xB1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002A59")]
		 set { } //Length: 177
	}

	[Address(RVA = "0x4A0570", Offset = "0x49F770", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002A6C")]
	private static AppearanceLoaderBase() { }

	[Address(RVA = "0x4A0600", Offset = "0x49F800", Length = "0x371")]
	[CalledBy(Type = typeof(NPCAppearance), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerAppearance), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SyncList`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "InitSyncObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyncObject)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x6002A6B")]
	public AppearanceLoaderBase() { }

	[Address(RVA = "0x49EF80", Offset = "0x49E180", Length = "0x5B6")]
	[CalledBy(Type = typeof(<ProcessAppearance>d__57), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AppearanceLoaderBase), Member = "ClearAppearance", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AppearanceLoaderBase), Member = "UpdateHats", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SyncList`1), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SyncList`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(AppearanceLoaderBase), Member = "UpdateBodyParts", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6002A65")]
	private void ApplyAppearance(AppearanceData data) { }

	[Address(RVA = "0x49F540", Offset = "0x49E740", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<ApplyBodyParts>d__62))]
	[Token(Token = "0x6002A69")]
	private IEnumerator ApplyBodyParts() { }

	[Address(RVA = "0x49F5B0", Offset = "0x49E7B0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<ApplyHats>d__60))]
	[Token(Token = "0x6002A67")]
	private IEnumerator ApplyHats() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A61")]
	protected override void Awake() { }

	[Address(RVA = "0x49F620", Offset = "0x49E820", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AppearanceLoaderBase), Member = "UpdateBodyParts", ReturnType = typeof(void))]
	[Token(Token = "0x6002A5E")]
	private void BodyChanged(string oldBody, string newBody) { }

	[Address(RVA = "0x49F650", Offset = "0x49E850", Length = "0x263")]
	[CalledBy(Type = typeof(NPCAppearance), Member = "ClearAppearance", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerAppearance), Member = "ClearAppearance", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AppearanceLoaderBase), Member = "ApplyAppearance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AppearanceData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AppearanceData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002A63")]
	public override void ClearAppearance() { }

	[Address(RVA = "0x49F8C0", Offset = "0x49EAC0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002A5D")]
	private void ClothingChanged(int oldClothing, int newClothing) { }

	[Address(RVA = "0x49F900", Offset = "0x49EB00", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002A5C")]
	private void ColorChanged(Color oldColor, Color newColor) { }

	[Address(RVA = "0x49F940", Offset = "0x49EB40", Length = "0x58E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color&), typeof(System.Action`2<UnityEngine.Color, UnityEngine.Color>), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(System.Action`2<System.Int32, System.Int32>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(System.Action`2<System.Object, System.Object>), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A85")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x3D64F0", Offset = "0x3D56F0", Length = "0x7")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A52")]
	public int get_FaceID() { }

	[Address(RVA = "0x4A0980", Offset = "0x49FB80", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A46")]
	public Color get_HeadColor() { }

	[Address(RVA = "0x4A0990", Offset = "0x49FB90", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A4A")]
	public Color get_LeftArmColor() { }

	[Address(RVA = "0x4A09A0", Offset = "0x49FBA0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A4E")]
	public Color get_LeftLegColor() { }

	[Address(RVA = "0x3D64F0", Offset = "0x3D56F0", Length = "0x7")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A7A")]
	public int get_NetworkfaceID() { }

	[Address(RVA = "0x4A0980", Offset = "0x49FB80", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A6E")]
	public Color get_NetworkheadColor() { }

	[Address(RVA = "0x4A0990", Offset = "0x49FB90", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A72")]
	public Color get_NetworkleftArmColor() { }

	[Address(RVA = "0x4A09A0", Offset = "0x49FBA0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A76")]
	public Color get_NetworkleftLegColor() { }

	[Address(RVA = "0x4A09B0", Offset = "0x49FBB0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A7E")]
	public int get_NetworkpantsID() { }

	[Address(RVA = "0x4A09C0", Offset = "0x49FBC0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A74")]
	public Color get_NetworkrightArmColor() { }

	[Address(RVA = "0x4A09D0", Offset = "0x49FBD0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A78")]
	public Color get_NetworkrightLegColor() { }

	[Address(RVA = "0x3D6530", Offset = "0x3D5730", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A7C")]
	public int get_NetworkshirtID() { }

	[Address(RVA = "0x4A09E0", Offset = "0x49FBE0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A70")]
	public Color get_NetworktorsoColor() { }

	[Address(RVA = "0x4A09F0", Offset = "0x49FBF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A80")]
	public int get_NetworktorsoID() { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A82")]
	public string get_NetworktorsoUrl() { }

	[Address(RVA = "0x4A09B0", Offset = "0x49FBB0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A56")]
	public int get_PantsID() { }

	[Address(RVA = "0x4A09C0", Offset = "0x49FBC0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A4C")]
	public Color get_RightArmColor() { }

	[Address(RVA = "0x4A09D0", Offset = "0x49FBD0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A50")]
	public Color get_RightLegColor() { }

	[Address(RVA = "0x3D6530", Offset = "0x3D5730", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A54")]
	public int get_ShirtID() { }

	[Address(RVA = "0x4A09E0", Offset = "0x49FBE0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A48")]
	public Color get_TorsoColor() { }

	[Address(RVA = "0x4A09F0", Offset = "0x49FBF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A58")]
	public int get_TorsoID() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A6A")]
	protected override void HatLoaded(GameObject hat) { }

	[Address(RVA = "0x49FED0", Offset = "0x49F0D0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AppearanceLoaderBase), Member = "UpdateHats", ReturnType = typeof(void))]
	[Token(Token = "0x6002A5B")]
	private void HatsChanged(Operation<String> op, int itemIndex, string oldItem, string newItem) { }

	[Address(RVA = "0x49FF00", Offset = "0x49F100", Length = "0xAE")]
	[CalledBy(Type = typeof(NPC), Member = "LoadAppearance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "SetUserID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "LoadAppearance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Player), Member = "ResetAppearance", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002A62")]
	public void LoadAppearance(int userID) { }

	[Address(RVA = "0x49FFB0", Offset = "0x49F1B0", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Action`4), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AppearanceLoaderBase), Member = "UpdateHats", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002A5A")]
	public virtual void OnStartClient() { }

	[Address(RVA = "0x4A00D0", Offset = "0x49F2D0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<ProcessAppearance>d__57))]
	[Token(Token = "0x6002A64")]
	private IEnumerator ProcessAppearance(int userID) { }

	[Address(RVA = "0x4A0150", Offset = "0x49F350", Length = "0x278")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A84")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x4A0A00", Offset = "0x49FC00", Length = "0x65")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A53")]
	public void set_FaceID(int value) { }

	[Address(RVA = "0x4A0A70", Offset = "0x49FC70", Length = "0x71")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A47")]
	public void set_HeadColor(Color value) { }

	[Address(RVA = "0x4A0AF0", Offset = "0x49FCF0", Length = "0x71")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A4B")]
	public void set_LeftArmColor(Color value) { }

	[Address(RVA = "0x4A0B70", Offset = "0x49FD70", Length = "0x71")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A4F")]
	public void set_LeftLegColor(Color value) { }

	[Address(RVA = "0x4A0A00", Offset = "0x49FC00", Length = "0x65")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A7B")]
	public void set_NetworkfaceID(in int value) { }

	[Address(RVA = "0x4A0A70", Offset = "0x49FC70", Length = "0x71")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A6F")]
	public void set_NetworkheadColor(in Color value) { }

	[Address(RVA = "0x4A0AF0", Offset = "0x49FCF0", Length = "0x71")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A73")]
	public void set_NetworkleftArmColor(in Color value) { }

	[Address(RVA = "0x4A0B70", Offset = "0x49FD70", Length = "0x71")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A77")]
	public void set_NetworkleftLegColor(in Color value) { }

	[Address(RVA = "0x4A0BF0", Offset = "0x49FDF0", Length = "0x65")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A7F")]
	public void set_NetworkpantsID(in int value) { }

	[Address(RVA = "0x4A0C60", Offset = "0x49FE60", Length = "0x71")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A75")]
	public void set_NetworkrightArmColor(in Color value) { }

	[Address(RVA = "0x4A0CE0", Offset = "0x49FEE0", Length = "0x71")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A79")]
	public void set_NetworkrightLegColor(in Color value) { }

	[Address(RVA = "0x4A0D60", Offset = "0x49FF60", Length = "0x65")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A7D")]
	public void set_NetworkshirtID(in int value) { }

	[Address(RVA = "0x4A0DD0", Offset = "0x49FFD0", Length = "0x71")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A71")]
	public void set_NetworktorsoColor(in Color value) { }

	[Address(RVA = "0x4A0E50", Offset = "0x4A0050", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A81")]
	public void set_NetworktorsoID(in int value) { }

	[Address(RVA = "0x4A0F10", Offset = "0x4A0110", Length = "0x13F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "get_activeHost", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVarHookGuard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002A83")]
	public void set_NetworktorsoUrl(in string value) { }

	[Address(RVA = "0x4A0BF0", Offset = "0x49FDF0", Length = "0x65")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A57")]
	public void set_PantsID(int value) { }

	[Address(RVA = "0x4A0C60", Offset = "0x49FE60", Length = "0x71")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A4D")]
	public void set_RightArmColor(Color value) { }

	[Address(RVA = "0x4A0CE0", Offset = "0x49FEE0", Length = "0x71")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A51")]
	public void set_RightLegColor(Color value) { }

	[Address(RVA = "0x4A0D60", Offset = "0x49FF60", Length = "0x65")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A55")]
	public void set_ShirtID(int value) { }

	[Address(RVA = "0x4A0DD0", Offset = "0x49FFD0", Length = "0x71")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A49")]
	public void set_TorsoColor(Color value) { }

	[Address(RVA = "0x4A0E50", Offset = "0x4A0050", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A59")]
	public void set_TorsoID(int value) { }

	[Address(RVA = "0x4A03D0", Offset = "0x49F5D0", Length = "0xCF")]
	[CalledBy(Type = typeof(AppearanceLoaderBase), Member = "BodyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AppearanceLoaderBase), Member = "ApplyAppearance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AppearanceData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002A68")]
	private void UpdateBodyParts() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A60")]
	protected override void UpdateClothing() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A5F")]
	protected override void UpdateColors() { }

	[Address(RVA = "0x4A04A0", Offset = "0x49F6A0", Length = "0xCF")]
	[CalledBy(Type = typeof(AppearanceLoaderBase), Member = "OnStartClient", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AppearanceLoaderBase), Member = "HatsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mirror.SyncList`1+Operation<System.String>), typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AppearanceLoaderBase), Member = "ApplyAppearance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AppearanceData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002A66")]
	private void UpdateHats() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002A6D")]
	public virtual bool Weaved() { }

}

