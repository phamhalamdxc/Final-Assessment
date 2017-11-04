/**
 * Requires npm, which is part of node.js <http://nodejs.org/>
 * To run:
 *   npm install
 *   grunt
 */
module.exports = function(grunt) {
  grunt.initConfig({
    pkg: grunt.file.readJSON('package.json'),
    paths: {
      sass: 'src/scss',
      demo: 'demo',
      demoSass: 'demo/includes/scss',
      css: 'demo/includes/css',
      cssDist: 'demo/includes/css/dist',
      bower: 'demo/includes/vendor'
    },

    clean: {
      sass: '<%= paths.css %>',
      bower: '<%= paths.bower %>'
    },
    shell: {
      bower: {
        command: 'bower install',
        options: {
          execOptions: {
            cwd: '<%= paths.demo %>'
          }
        }
      }
    },
    sass: {
      demo: {
        options: {
          outputStyle: 'compressed',
          includePaths: [
            '<%= paths.sass %>',
            '<%= paths.css %>',
            '<%= paths.demo %>/fonts/foundation-icons',
            '<%= paths.bower %>/foundation/scss',
            '<%= paths.bower %>/foundation-icon-fonts/',
          ]
        },
        files: {
          '<%= paths.cssDist %>/main.min.css':
            '<%= paths.demoSass %>/main.scss'
        }
      }
    },
    watch: {
      bower: {
        files: ['bower.json'],
        tasks: [
          'shell:bower',
        ]
      },
      sass: {
        files: [
          '<%= paths.sass %>/**/*.scss',
          '<%= paths.demoSass %>/**/*.scss',
        ],
        tasks: ['sass','notify:sass']
      }
    },
    notify: {
      sass: {
        options: {
          title: 'Sass',
          message: 'CSS updated.'
        }
      }
    }
  });

  grunt.loadNpmTasks('grunt-contrib-clean');
  grunt.loadNpmTasks('grunt-contrib-watch');
  grunt.loadNpmTasks('grunt-notify');
  grunt.loadNpmTasks('grunt-sass');
  grunt.loadNpmTasks('grunt-shell');

  grunt.registerTask('default', [
    'clean:bower',
    'shell:bower',
    'sass',
  ]);
}
