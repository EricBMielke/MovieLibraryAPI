
$(document).ready(function(){
    $.ajax({
        type: "GET",
        url: 'https://localhost:44378/movies',
        dataType: 'json',
        success: function () {
            $('.movieData').html('')
        }
    })
    .then(function(data){
        var movie_data = '';
            $.each(data, function (key, value) {
                movie_data += '<tr>';
                movie_data += '<td>' + value.MovieId + '</td>';
                movie_data += '<td>' + value.Genre + '</td>';
                movie_data += '<td>' + value.Title + '</td>';
                movie_data += '<td>' + value.DirectorName + '</td>';
                movie_data += '</tr>';
            });
            $('.movieData').append(movie_data);
    });
})

