using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
	public int worldSize = 5;
	private int chunkSize = 16;

	private Dictionary<Vector3, Chunk> chunks;

	public static World Instance { get; private set; }

public Material VoxelMaterial;

void Awake()
{
    if (Instance == null)
    {
        Instance = this;
        DontDestroyOnLoad(gameObject); // Optional: if you want this to persist across scenes
    }
    else
    {
        Destroy(gameObject);
    }
}

	void Start()
	{
		chunks = new Dictionary<Vector3, Chunk>();

		GenerateWorld();
	}

public Chunk GetChunkAt(Vector3 globalPosition)
{
    // Calculate the chunk's starting position based on the global position
    Vector3Int chunkCoordinates = new Vector3Int(
        Mathf.FloorToInt(globalPosition.x / chunkSize) * chunkSize,
        Mathf.FloorToInt(globalPosition.y / chunkSize) * chunkSize,
        Mathf.FloorToInt(globalPosition.z / chunkSize) * chunkSize
    );

    // Retrieve and return the chunk at the calculated position
    if (chunks.TryGetValue(chunkCoordinates, out Chunk chunk))
    {
        return chunk;
    }

    // Return null if no chunk exists at the position
    return null;
}

	private void GenerateWorld()
	{
		for (int x = 0; x < worldSize; x++)
		{
            		for (int y = 0; y < worldSize; y++)
            		{
                		for (int z = 0; z < worldSize; z++)
                		{
                    			Vector3 chunkPosition = new Vector3(x * chunkSize, y * chunkSize, z * chunkSize);
                    			GameObject newChunkObject = new GameObject($"Chunk_{x}_{y}_{z}");
                    			newChunkObject.transform.parent = this.transform;

                    			Chunk newChunk = newChunkObject.AddComponent<Chunk>();
                    			newChunk.Initialize(chunkSize);
                    			chunks.Add(chunkPosition, newChunk);
                		}
            		}
        	}
	}
}
