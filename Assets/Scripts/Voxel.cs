using UnityEngine;

public struct Voxel
{
  public Vector3 position;
  public bool isActive;
  public VoxelType type;

  public enum VoxelType
  {
	  Air,
	  Grass,
	  Stone,
  }

  public Voxel(Vector3 position, VoxelType type, bool isActive = true)
  {
	  this.position = position;
	  this.type = type;
	  this.isActive = isActive;
  }
}
