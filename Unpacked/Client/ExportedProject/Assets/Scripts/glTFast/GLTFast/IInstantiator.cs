namespace GLTFast;

[Token(Token = "0x200003E")]
public interface IInstantiator
{

	[Token(Token = "0x6000112")]
	public void AddAnimation(AnimationClip[] animationClips) { }

	[Token(Token = "0x6000117")]
	public void AddCamera(uint nodeIndex, uint cameraIndex) { }

	[Token(Token = "0x6000118")]
	public void AddLightPunctual(uint nodeIndex, uint lightIndex) { }

	[Token(Token = "0x6000115")]
	public void AddPrimitive(uint nodeIndex, string meshName, MeshResult meshResult, UInt32[] joints = null, Nullable<UInt32> rootJoint = null, Single[] morphTargetWeights = null, int primitiveNumeration = 0) { }

	[Token(Token = "0x6000116")]
	public void AddPrimitiveInstanced(uint nodeIndex, string meshName, MeshResult meshResult, uint instanceCount, Nullable<NativeArray`1<Vector3>> positions, Nullable<NativeArray`1<Quaternion>> rotations, Nullable<NativeArray`1<Vector3>> scales, int primitiveNumeration = 0) { }

	[Token(Token = "0x6000111")]
	public void BeginScene(string name, UInt32[] rootNodeIndices) { }

	[Token(Token = "0x6000113")]
	public void CreateNode(uint nodeIndex, Nullable<UInt32> parentIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[Token(Token = "0x6000119")]
	public void EndScene(UInt32[] rootNodeIndices) { }

	[Token(Token = "0x6000114")]
	public void SetNodeName(uint nodeIndex, string name) { }

}

