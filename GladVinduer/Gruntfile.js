

module.exports = function (grunt) {
  
  grunt.initConfig({
      postcss: {
          options: {
              map: true,

              map: {
                  inline: false, 
                  annotation: 'dist/css/maps/'
              },

              processors: [
                  require('pixrem')(), // add fallbacks for rem units
                  require('autoprefixer')({ browsers: 'last 2 versions' }), // add vendor prefixes
                  require('cssnano')() // minify the result
              ]
          },
          dist: {
              src: 'css/*.css'
          }
      }

     
    });
  grunt.registerTask('build', ['']);
  grunt.registerTask('default', []);
};