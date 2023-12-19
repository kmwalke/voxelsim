SIZE = 10;

universe = Array.new(SIZE) {Array.new(SIZE) {Array.new(SIZE)} }

universe.each_with_index do |layer, x| 

  universe[x].each_with_index do |column, y|

    universe[x][y].each_with_index do |voxel, z|

      universe[x][y][z] = rand(2)

    end

  end

end

output = '';

universe.each_with_index do |layer, x| 


  output += "#layer: #{x}\n"
  universe[x].each_with_index do |column, y|

    line = ''

    universe[x][y].each_with_index do |voxel, z|

      line += universe[x][y][z].to_s

    end

    output += line + "\n"
  end


end


File.open('out.vxl', 'w') { |file| file.write(output) }
