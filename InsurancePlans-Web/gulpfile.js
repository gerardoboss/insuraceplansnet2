'use strict';

var gulp = require('gulp'),
    concat = require('gulp-concat'),
    cleanCSS = require('gulp-clean-css'),
    scss = require('gulp-sass'),
    postcss = require('gulp-postcss');

gulp.task('sass', function () {
    return gulp.src('wwwroot/*/*.scss')
        .pipe(concat('style.min.scss'))
        .pipe(scss())
        .pipe(cleanCSS())
        .pipe(gulp.dest('wwwroot/css'))
});