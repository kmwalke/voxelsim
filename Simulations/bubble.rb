require './voxel_file.rb'

if ARGV.length < 1
  puts 'You must supply a filename'
  exit 1
end



puts VoxelFile.new.thing
