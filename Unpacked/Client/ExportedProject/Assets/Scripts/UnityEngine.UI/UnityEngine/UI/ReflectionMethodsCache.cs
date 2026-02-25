namespace UnityEngine.UI;

[Token(Token = "0x200007A")]
internal class ReflectionMethodsCache
{
	[Token(Token = "0x200007D")]
	internal sealed class GetRaycastNonAllocCallback : MulticastDelegate
	{

		[Address(RVA = "0x1CC86C0", Offset = "0x1CC78C0", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600050F")]
		public GetRaycastNonAllocCallback(object object, IntPtr method) { }

		[Address(RVA = "0x1CC8770", Offset = "0x1CC7970", Length = "0xB8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x6000511")]
		public override IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object object) { }

		[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000512")]
		public override int EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x1CC8680", Offset = "0x1CC7880", Length = "0x40")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000510")]
		public override int Invoke(Ray r, RaycastHit[] results, float f, int i) { }

	}

	[Token(Token = "0x200007F")]
	internal sealed class GetRayIntersectionAllCallback : MulticastDelegate
	{

		[Address(RVA = "0x1CC8510", Offset = "0x1CC7710", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000517")]
		public GetRayIntersectionAllCallback(object object, IntPtr method) { }

		[Address(RVA = "0x1CC8420", Offset = "0x1CC7620", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x6000519")]
		public override IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x600051A")]
		public override RaycastHit2D[] EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x1CC84D0", Offset = "0x1CC76D0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000518")]
		public override RaycastHit2D[] Invoke(Ray r, float f, int i) { }

	}

	[Token(Token = "0x2000080")]
	internal sealed class GetRayIntersectionAllNonAllocCallback : MulticastDelegate
	{

		[Address(RVA = "0x1CC86C0", Offset = "0x1CC78C0", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600051B")]
		public GetRayIntersectionAllNonAllocCallback(object object, IntPtr method) { }

		[Address(RVA = "0x1CC85C0", Offset = "0x1CC77C0", Length = "0xB8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x600051D")]
		public override IAsyncResult BeginInvoke(Ray r, RaycastHit2D[] results, float f, int i, AsyncCallback callback, object object) { }

		[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600051E")]
		public override int EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x1CC8680", Offset = "0x1CC7880", Length = "0x40")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600051C")]
		public override int Invoke(Ray r, RaycastHit2D[] results, float f, int i) { }

	}

	[Token(Token = "0x200007E")]
	internal sealed class Raycast2DCallback : MulticastDelegate
	{

		[Address(RVA = "0x1CCA1D0", Offset = "0x1CC93D0", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000513")]
		public Raycast2DCallback(object object, IntPtr method) { }

		[Address(RVA = "0x1CCA060", Offset = "0x1CC9260", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x6000515")]
		public override IAsyncResult BeginInvoke(Vector2 p1, Vector2 p2, float f, int i, AsyncCallback callback, object object) { }

		[Address(RVA = "0x1CCA120", Offset = "0x1CC9320", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000516")]
		public override RaycastHit2D EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x1CCA170", Offset = "0x1CC9370", Length = "0x59")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000514")]
		public override RaycastHit2D Invoke(Vector2 p1, Vector2 p2, float f, int i) { }

	}

	[Token(Token = "0x200007B")]
	internal sealed class Raycast3DCallback : MulticastDelegate
	{

		[Address(RVA = "0x1CCA360", Offset = "0x1CC9560", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000507")]
		public Raycast3DCallback(object object, IntPtr method) { }

		[Address(RVA = "0x1CCA280", Offset = "0x1CC9480", Length = "0xD3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x6000509")]
		public override IAsyncResult BeginInvoke(Ray r, out RaycastHit hit, float f, int i, AsyncCallback callback, object object) { }

		[Address(RVA = "0x395AE0", Offset = "0x394CE0", Length = "0x30")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600050A")]
		public override bool EndInvoke(out RaycastHit hit, IAsyncResult result) { }

		[Address(RVA = "0x1CC8680", Offset = "0x1CC7880", Length = "0x40")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000508")]
		public override bool Invoke(Ray r, out RaycastHit hit, float f, int i) { }

	}

	[Token(Token = "0x200007C")]
	internal sealed class RaycastAllCallback : MulticastDelegate
	{

		[Address(RVA = "0x1CC8510", Offset = "0x1CC7710", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600050B")]
		public RaycastAllCallback(object object, IntPtr method) { }

		[Address(RVA = "0x1CCA410", Offset = "0x1CC9610", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x600050D")]
		public override IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x600050E")]
		public override RaycastHit[] EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x1CC84D0", Offset = "0x1CC76D0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600050C")]
		public override RaycastHit[] Invoke(Ray r, float f, int i) { }

	}

	[Token(Token = "0x4000263")]
	private static ReflectionMethodsCache s_ReflectionMethodsCache; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400025D")]
	public Raycast3DCallback raycast3D; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400025E")]
	public RaycastAllCallback raycast3DAll; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400025F")]
	public GetRaycastNonAllocCallback getRaycastNonAlloc; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000260")]
	public Raycast2DCallback raycast2D; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000261")]
	public GetRayIntersectionAllCallback getRayIntersectionAll; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000262")]
	public GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc; //Field offset: 0x38

	[Token(Token = "0x17000152")]
	public static ReflectionMethodsCache Singleton
	{
		[Address(RVA = "0x1CCCE30", Offset = "0x1CCC030", Length = "0x8D")]
		[CalledBy(Type = typeof(GraphicRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Physics2DRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PhysicsRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ReflectionMethodsCache), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000506")]
		 get { } //Length: 141
	}

	[Address(RVA = "0x1CCBE60", Offset = "0x1CCB060", Length = "0xFCB")]
	[CalledBy(Type = typeof(ReflectionMethodsCache), Member = "get_Singleton", ReturnType = typeof(ReflectionMethodsCache))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(MethodInfo)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type[])}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000505")]
	public ReflectionMethodsCache() { }

	[Address(RVA = "0x1CCCE30", Offset = "0x1CCC030", Length = "0x8D")]
	[CalledBy(Type = typeof(GraphicRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Physics2DRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PhysicsRaycaster), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ReflectionMethodsCache), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000506")]
	public static ReflectionMethodsCache get_Singleton() { }

}

