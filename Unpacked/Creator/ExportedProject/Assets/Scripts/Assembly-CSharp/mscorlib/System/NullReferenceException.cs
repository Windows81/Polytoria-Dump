namespace System;

[Token(Token = "0x2000118")]
public class NullReferenceException : SystemException
{

	[Address(RVA = "0x14A4690", Offset = "0x14A3890", Length = "0x44")]
	[CalledBy(Type = typeof(Enum), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Assembly), Member = "LoadWithPartialName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Evidence)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(Assembly), Member = "LoadWithPartialName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Evidence), typeof(bool)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(RuntimeAssembly), Member = "LoadWithPartialNameInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Evidence), typeof(StackCrawlMark&)}, ReturnType = typeof(RuntimeAssembly))]
	[CalledBy(Type = typeof(RuntimeAssembly), Member = "LoadWithPartialNameInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssemblyName), typeof(Evidence), typeof(StackCrawlMark&)}, ReturnType = typeof(RuntimeAssembly))]
	[CalledBy(Type = "UnityEngine.Camera", Member = "GetAllCameras", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Camera[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NullCheckInstruction", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionNoT+Value", Member = "ConvertNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.AudioClip", Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(bool), "UnityEngine.AudioClip+PCMReaderCallback", "UnityEngine.AudioClip+PCMSetPositionCallback"}, ReturnType = "UnityEngine.AudioClip")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60008A7")]
	public NullReferenceException() { }

	[Address(RVA = "0x14A4670", Offset = "0x14A3870", Length = "0x1E")]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "StartCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = "UnityEngine.Coroutine")]
	[CalledBy(Type = "Unity.Hierarchy.HierarchyPropertyUnmanaged`1", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Hierarchy.HierarchyNode&", "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "StopCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Coroutine"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "StopCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "StartCoroutine_Auto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = "UnityEngine.Coroutine")]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "StartCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = "UnityEngine.Coroutine")]
	[CalledBy(Type = "Unity.Hierarchy.HierarchyPropertyUnmanaged`1", Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Hierarchy.HierarchyNode&"}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "StartCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.Coroutine")]
	[CalledBy(Type = "UnityEngine.Camera", Member = "AddCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.CameraEvent", "UnityEngine.Rendering.CommandBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1Sequence", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.BouncyCastle.Asn1.Asn1Encodable[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.SocketAsyncEventArgs"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.SocketAsyncEventArgs"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.TabView", Member = "set_activeTab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Tab"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Camera", Member = "RemoveCommandBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.CameraEvent", "UnityEngine.Rendering.CommandBuffer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandler", Member = "GetCheckedDownloader", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Networking.UnityWebRequest"}, ReturnType = "T")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60008A8")]
	public NullReferenceException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008A9")]
	protected NullReferenceException(SerializationInfo info, StreamingContext context) { }

}

