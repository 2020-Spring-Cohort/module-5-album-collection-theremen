export default function ViewSongs(album) {
    return `
    <h3>${album.title}</h3>
    <ol id="view-songs">
        ${album.songs.map(song => {
            return `
            <li class="song">
            <div id="songs">
                <h4 class="song__name">${song.songTitle}</h4>
                <div> ${song.duration}</div>
                <a href="${song.links}" target="_blank">Link to Song</a>
                </br>
                <button class="edit-song__submit">Edit</button>
                <button class="delete-song__submit">Delete</button>
                <input class="song__id" type="hidden" value="${song.songId}">
                <input class="song__albumId" type="hidden" value="${song.albumId}">
           </div
                </li>
            `
        }).join("")}
    </ol>

    <section class="add-song">
           <input class="add-song__songTitle" type="text" placeholder="Add a Song here">
           <input class="add-song__songLink" type="text" placeholder="Add a Song Link here">
            <input class="add-song__songDuration" type="text" placeholder="Add the Song Duration here">
            <input class="add-song__albumId" type="hidden" value="${album.albumId}">
           <button class="add-song__submit">Add a Song</button>
        </section>

    <button class="view-albums">Go Back</button>
    `
}