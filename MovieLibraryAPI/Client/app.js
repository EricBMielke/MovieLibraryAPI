<script>
    $.ajax({
        type: "GET",
        url: https://localhost:44378/movies,
        data: { input: input },
        success: function (data) {
            var movie_data = '';
            $.each(data, function (key, value) {
                movie_data += '<tr>';
                movie_data += '<td>' + value.MovieId + '</td>';
                movie_data += '<td>' + value.Genre + '</td>';
                movie_data += '<td>' + value.Title + '</td>';
                movie_data += '<td>' + value.DirectorName + '</td>';
                movie_data += '</tr>';
            });
            $('#movie_table').append(movie_data);
        });
  });
</script>