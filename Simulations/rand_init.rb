require './voxel_file.rb'

SIZE = 10;

universe = Array.new(SIZE) {Array.new(SIZE) {Array.new(SIZE)} }

universe.each_with_index do |layer, x| 

  universe[x].each_with_index do |column, y|

    universe[x][y].each_with_index do |voxel, z|

      universe[x][y][z] = rand(2)

    end

  end

end

vf = VoxelFile.new(size: SIZE, data: universe, filename: 'rand_init')
vf.write_file
