export default function ViewSongs(album) {
    return `
    <h3>${album.title}</h3>
    <ul id="view-songs">
        ${album.songs.map(song => {
            return `
            <li class="song">
                <h4 class="song__name">${song.songTitle}</h4>
                ${song.links}
               <div> ${song.duration}</div>
                <button class="edit-song__submit">Edit</button>
                <button class="delete-song__submit">Delete</button>
                <input class="song__id" type="hidden" value="${song.songId}">
            </li>
            `
        }).join("")}
    </ul>
    <button class="view-albums">Go Back</button>`
}