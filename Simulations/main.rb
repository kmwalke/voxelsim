SIZE = 1000;

universe = Array.new(3) {Array.new(SIZE)}

universe.each_with_index do |axis, i| 

  universe[i].each_with_index do |voxel, j|

    universe[i][j] = rand(2)

  end

end


universe.each_with_index do |axis, i| 

  output = ''

  universe[i].each_with_index do |voxel, j|

    output += universe[i][j].to_s

  end

  puts i
  puts output

end

