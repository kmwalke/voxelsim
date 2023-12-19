class VoxelFile
  def initialize(filename:, size:, data:)
    @size = size
    @data = data
    @filename = filename
  end
  
  def write_file
    output = '';

    @data.each_with_index do |layer, x| 

    output += "#size: #{@size}\n"
    output += "#layer: #{x}\n"
    @data[x].each_with_index do |column, y|

      line = ''

      @data[x][y].each_with_index do |voxel, z|

        line += @data[x][y][z].to_s

      end

      output += line + "\n"
    end
  end


  File.open("#{@filename}.vxl", 'w') { |file| file.write(output) }
  end

end
