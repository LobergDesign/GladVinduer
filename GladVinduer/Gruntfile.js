module.exports = function(grunt) {
  
  grunt.initConfig({
      autoprefixer: {
          dist: {
              files: {
                  '/Content/Style/styles.css': '/Content/Style/Other/styles.css'
              }
          },
      },
    });
  grunt.registerTask('build', ['autoprefixer']);
  grunt.registerTask('default', []);
};