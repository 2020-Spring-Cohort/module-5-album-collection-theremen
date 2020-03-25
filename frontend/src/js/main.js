import Header from './components/Header';
import Footer from './components/Footer';
import Homepage from './components/Homepage';
import ViewArtists from './components/ViewArtists';
import ViewAlbums from './components/ViewAlbums';
import AboutUs from './components/AboutUs';
import apiActions from './api/apiActions';
import EditArtist from './components/EditArtist';
import ViewSongs from './components/ViewSongs';
import EditSong from './components/EditSong';
import EditAlbum from './components/EditAlbum';


export default pageBuild

function pageBuild(){
    header()
    homepage()
    footer()
    viewArtists()
    aboutUs()
}

function header() {
    const header = document.querySelector('#header')
    header.innerHTML = Header()
}

function footer() {
    const footer = document.querySelector('#footer')
    footer.innerHTML = Footer()
}

function homepage() {
    const homePageButton = document.querySelector('#home')
    homePageButton.addEventListener('click', function(){
        document.querySelector('#app').innerHTML = Homepage()
    })
}

function viewArtists() {
    const app = document.querySelector('#app');
    const ourMusic = document.querySelector('#our-music')
    ourMusic.addEventListener('click', function(){
        apiActions.getRequest("https://localhost:44313/api/Artist",
        artists => {
            console.log(artists);
            app.innerHTML = ViewArtists(artists);
        })
    })
///////EDIT ARTIST PAGE 
    app.addEventListener("click", function(){
        if(event.target.classList.contains('edit-artist__submit')){
            const artistId = event.target.parentElement.querySelector('.artist__id').value;
            console.log(artistId);
            apiActions.getRequest(
                `https://localhost:44313/api/Artist/${artistId}`,
                artistEdit => {
                    console.log(artistEdit);
                    app.innerHTML = EditArtist(artistEdit);
                  }
            )
        }
    })
/// SAVES ARTIST
    app.addEventListener('click', function(){
        if(event.target.classList.contains('update-artist__submit')){
            const artistId = event.target.parentElement.querySelector('.update-artist__id').value;
            const artistName = event.target.parentElement.querySelector('.update-artist__name').value
            const artistImage = event.target.parentElement.querySelector('.update-artist__image').value
            const artistHometown = event.target.parentElement.querySelector('.update-artist__hometown').value

            const artistData = {
                artistId: artistId,
                name: artistName,
                image: artistImage,
                hometown: artistHometown
            };
            console.log(artistData)

            apiActions.putRequest(
                `https://localhost:44313/api/Artist/${artistId}`,
                artistData,
                artists => {
                    app.innerHTML = ViewArtists(artists);
                }
            )
        }
    })
/// DELETE ARTIST
    app.addEventListener("click", function(){
        if(event.target.classList.contains('delete-artist__submit')){
            const artistId = event.target.parentElement.querySelector('.artist__id').value;
            console.log(artistId);

            apiActions.deleteRequest(
                `https://localhost:44313/api/Artist/${artistId}`,
                artists => {
                    app.innerHTML = ViewArtists(artists);
                }
            )
        }
    })

/// ADD ALBUM - RETURNS TO ALBUMS
    app.addEventListener('click', function(){
        if(event.target.classList.contains('add-album__submit')){
            const title = event.target.parentElement.querySelector('.add-album__title').value;
            const image = event.target.parentElement.querySelector('.add-album__image').value;
            const recordLabel = event.target.parentElement.querySelector('.add-album__recordLabel').value;
            const artistId = event.target.parentElement.querySelector('.album__artistid').value;
            var requestBody = {
                Title: title,
                Image: image,
                RecordLabel: recordLabel,
                artistId: artistId
            }
            console.log(requestBody)
            apiActions.postRequest(
                "https://localhost:44313/api/Album",
                requestBody,
                albums => {
                    apiActions.getRequest(
                        `https://localhost:44313/api/Artist/${artistId}`,
                        artist => {
                            app.innerHTML = ViewAlbums(artist)
                        }
                    )  
                   // app.innerHTML = ViewAlbums(albums)
                }
            ) 
        }
    })

/// ADD ARTIST
    app.addEventListener('click', function(){
        if(event.target.classList.contains('add-artist__submit')){
            const artistName = event.target.parentElement.querySelector('.add-artist__artistName').value;
            const artistImage = event.target.parentElement.querySelector('.add-artist__artistImage').value;
            const artistHometown = event.target.parentElement.querySelector('.add-artist__artistHometown').value;
            var requestBody = {
                Name: artistName,
                Image: artistImage,
                Hometown: artistHometown
            }
            apiActions.postRequest(
                "https://localhost:44313/api/Artist",
                requestBody,
                artists => {
                    console.log("Artists returned from backend")
                    console.log(artists);
                    app.innerHTML = ViewArtists(artists)
                }
            )
        }
    })
  /// GO TO VIEW ALBUMS
    app.addEventListener('click', function(){
        if(event.target.classList.contains('artist__name')){
            const artistId = event.target.parentElement.querySelector(".artist__id").value
            console.log(artistId)
            apiActions.getRequest(
                `https://localhost:44313/api/Artist/${artistId}`,
                artist => {
                    console.log(artist);
                    app.innerHTML = ViewAlbums(artist);
                  }
            )
        }
    })
/// GO TO VIEW SONGS
    app.addEventListener('click', function(){
        if(event.target.classList.contains('album__name')){
            const albumId = event.target.parentElement.querySelector(".album__id").value
            console.log(albumId)
            apiActions.getRequest(
                `https://localhost:44313/api/Album/${albumId}`,
                album => {
                    console.log(album);
                    app.innerHTML = ViewSongs(album);
                }
            )
        }
    })
    // ???
    app.addEventListener('click', function(){
        if(event.target.classList.contains('view-artists')){
            apiActions.getRequest(
                `https://localhost:44313/api/Artist/`,
                artists => {
                    console.log(artists);
                    app.innerHTML = ViewArtists(artists);
                }
            )
        }
    })

    // Edit Album
    app.addEventListener("click", function(){
        if(event.target.classList.contains('edit-album__submit')){
            const albumId = event.target.parentElement.querySelector('.album__id').value;
            console.log(albumId);
            apiActions.getRequest(
                `https://localhost:44313/api/Album/${albumId}`,
                albumEdit => {
                    console.log(albumEdit);
                    app.innerHTML = EditAlbum(albumEdit);
                  }
            )
        }
    })
    // Save edits / returns to Albums
    app.addEventListener('click', function(){
        if(event.target.classList.contains('update-album__submit')){
            const albumId = event.target.parentElement.querySelector('.update-album__id').value;
            const albumTitle = event.target.parentElement.querySelector('.update-album__title').value
            const albumImage = event.target.parentElement.querySelector('.update-album__image').value
            const recordLabel = event.target.parentElement.querySelector('.update-album__recordLabel').value
            const artistId = event.target.parentElement.querySelector('.update-album__artistId').value;
            const albumData = {
                albumId: albumId,
                title: albumTitle,
                image: albumImage,
                recordLabel: recordLabel,
                artistId: artistId
            };
            console.log(albumData)
            apiActions.putRequest(
                `https://localhost:44313/api/Album/${albumId}`,
                albumData,
                albums => {
                    apiActions.getRequest(
                        `https://localhost:44313/api/Artist/${artistId}`,
                        artist => {
                            app.innerHTML = ViewAlbums(artist)
                        }
                    )  
                }
            )
        }
    })
    // Delete Album
    app.addEventListener("click", function(){
        if(event.target.classList.contains('delete-album__submit')){
            const albumId = event.target.parentElement.querySelector('.album__id').value;
            const artistId = event.target.parentElement.querySelector('.album__artistId').value;
            console.log(artistId);
    
            apiActions.deleteRequest(
                `https://localhost:44313/api/Album/${albumId}`,
                albums => {
                    apiActions.getRequest(
                        `https://localhost:44313/api/Artist/${artistId}`,
                        artist => {
                            app.innerHTML = ViewAlbums(artist)
                        }
                    )  
                }
            )
        }
    })
    /// ADD SONGS AND RETURN TO SONGS
    app.addEventListener('click', function(){
      if(event.target.classList.contains('add-song__submit')){
          const songTitle = event.target.parentElement.querySelector('.add-song__songTitle').value;
          const songLink = event.target.parentElement.querySelector('.add-song__songLink').value;
          const songDuration = event.target.parentElement.querySelector('.add-song__songDuration').value;
          const albumId = event.target.parentElement.querySelector('.add-song__albumId').value;
          var requestBody = {
              songTitle: songTitle,
              links: songLink,
              duration: songDuration,
              albumId: albumId
          }
          apiActions.postRequest(
              "https://localhost:44313/api/Song",
              requestBody,
              songs => {
                  //alert("post")
                  //app.innerHTML = ViewSongs(album)
                  apiActions.getRequest(
                      `https://localhost:44313/api/Album/${albumId}`,
                      album => {
                          console.log(album);
                          app.innerHTML = ViewSongs(album);
                      }
                  )
              }
          ) 
      }
    })
    }
/// EDIT SONGS
    app.addEventListener("click", function(){
        if(event.target.classList.contains('edit-song__submit')){
            const songId = event.target.parentElement.querySelector('.song__id').value;
            console.log(songId);
            apiActions.getRequest(
                `https://localhost:44313/api/Song/${songId}`,
                songEdit => {
                    console.log(songEdit);
                    app.innerHTML = EditSong(songEdit);
                }
            )
        }
    })
/// SAVES EDIT AND RETURNS TO SONGS
    app.addEventListener('click', function(){
        if(event.target.classList.contains('update-song__submit')){
            const songId = event.target.parentElement.querySelector('.update-song__id').value;
            const songTitle = event.target.parentElement.querySelector('.update-song__title').value
            const songLink = event.target.parentElement.querySelector('.update-song__link').value
            const songDuration = event.target.parentElement.querySelector('.update-song__duration').value
            const albumId = event.target.parentElement.querySelector('.update-song__albumId').value

            const songData = {
                songId: songId,
                songTitle: songTitle,
                links: songLink,
                duration: songDuration,
                albumId: albumId
            };
            console.log(songData)

            apiActions.putRequest(
                `https://localhost:44313/api/Song/${songId}`,
                songData,
                songs => {
                    apiActions.getRequest(
                        `https://localhost:44313/api/Album/${albumId}`,
                        album => {
                            console.log(album);
                            app.innerHTML = ViewSongs(album);
                        }
                    )
                }
            )
        }
    })
    /// DELETE SONGS - RETURNS TO SONGS
    app.addEventListener("click", function(){
        if(event.target.classList.contains('delete-song__submit')){
            const songId = event.target.parentElement.querySelector('.song__id').value;
            const albumId = event.target.parentElement.querySelector('.song__albumId').value;
            console.log(songId);
    
            apiActions.deleteRequest(
                `https://localhost:44313/api/Song/${songId}`,
                songs => {
                    apiActions.getRequest(
                        `https://localhost:44313/api/Album/${albumId}`,
                        album => {
                            console.log(album);
                            app.innerHTML = ViewSongs(album);
                        }
                    )
                }
            )
        }
    })
  

function aboutUs() {
    const aboutUs = document.querySelector('#about-us')
    aboutUs.addEventListener('click', function(){
        document.querySelector('#app').innerHTML = AboutUs()
    })
}