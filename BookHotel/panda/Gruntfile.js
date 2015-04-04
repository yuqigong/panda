module.exports = function (grunt){

    grunt.initConfig({
        watch : {
            test : {
                files : ['test/main.less'],
                tasks : ['less']
            }
        },
        less : {
            test : {
                options : {
                    compress : true
                },
                files: {
                    "test/main.css": "test/main.less"
                }
            }
        }
    });

    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-contrib-less');

    grunt.registerTask('dev',[
        'watch'
    ]);

    grunt.registerTask('pro',[
        'concat'
    ]);
};