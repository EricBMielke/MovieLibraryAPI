
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
                movie_data += '<td>' + value.Genre + '</td>';
                movie_data += '<td>' + value.Title + '</td>';
                movie_data += '<td>' + value.DirectorName + '</td>';
                movie_data += '<td><button class="edit" onclick = "GetSpecificMovie('+value.MovieId+')"data-key="'+ (key + 1) +'">Edit</button></td>';
                movie_data += '<td><button class="edit" id ="pictureButton" onclick = "GetSpecificPicture('+value.MovieId+')"data-key="'+ (key + 1) +'">Picture</button></td>';
                movie_data += '</tr>';
            });
            $('.movieData').append(movie_data);
    });
})

function MakeMovie()
    {
        var data = {
            Genre : document.getElementById("Genre").value,
            Title : document.getElementById("Title").value,
            DirectorName : document.getElementById("DirectorName").value,
            PictureURL : document.getElementById("PictureURL").value,
        };
        return data;
    }

function AddMovie(){

    let movie = MakeMovie();
    $.ajax({
    type: "POST",
    url: 'https://localhost:44378/movies',
    dataType : 'json',
    data : movie,
    success: function() {
        location.reload();
    }
    })
}
function GetSpecificMovie(id){
    $.ajax({
        type: "GET",
        url: 'https://localhost:44378/movies/movie/'+id,
        dataType: 'json',
        success: function () {
        }
    })
    .then(function(data){
        $("#GenreEdit").show();
        $("#TitleEdit").show();
        $("#DirectorNameEdit").show();
        $("#PictureURLEdit").show();
        $("#EditButton").show();
        $("#EditHeader").show();
        $('#DirectorNameEdit').val(data.DirectorName),
        $('#PictureURLEdit').val(data.PictureURL),
        $('#GenreEdit').val(data.Genre),
        $('#TitleEdit').val(data.Title),
        $('#hiddenMovieId').val(data.MovieId)
    });
}

function GetSpecificPicture(id){
    $.ajax({
        type: "GET",
        url: 'https://localhost:44378/movies/movie/'+id,
        dataType: 'json',
        success: function () {
        }
    })
    .then(function(data){
        $('#MoviePicture').attr('src', data.PictureURL)
        $("#MoviePicture").show();
        $('#hiddenPictureURL').val(data.PictureURL)
    });
}


function UpdateMovie(){
    let movie = PutMovie();
    let id = $ ('#hiddenMovieId').val();
    $.ajax({
        type: "PUT",
        url: 'https://localhost:44378/movies/movie/'+ id,
        dataType : "JSON",
        data : movie,
        success : function(){
            location.reload();
        }
    })
}

function PutMovie()
{ 
    var data = {
        Genre : document.getElementById("GenreEdit").value,
        Title : document.getElementById("TitleEdit").value,
        DirectorName : document.getElementById("DirectorNameEdit").value,
        PictureURL : document.getElementById("PictureURLEdit").value,
        MovieId: this.MovieId
    };
    return data;
}


