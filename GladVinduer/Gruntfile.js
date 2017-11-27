

module.exports = function (grunt) {
  
    grunt.initConfig({
        postcss: {
            options: {
                map: true, // inline sourcemaps

                // or
                map: {
                    inline: false, // save all sourcemaps as separate files...
                    annotation: '/Content/Test/dist/css/maps/' // ...to the specified directory
                },

                processors: [
                    require('pixrem')(), // add fallbacks for rem units
                    require('autoprefixer')({ browsers: 'last 2 versions' }), // add vendor prefixes
                    require('cssnano')() // minify the result
                ]
            },
            files: {
                'dest/default_options': ['/Content/Style/Test/testing', 'src/123'],
            },
            //dist: {
            //    src: 'css/*.css'
            //}
        }
    });

  grunt.registerTask('build', ['postcss']);
  grunt.registerTask('default', []);
  grunt.loadNpmTasks('grunt-postcss');
};