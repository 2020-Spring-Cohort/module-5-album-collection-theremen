export default function ViewSongs(album) {
    return `
    <ul id="view-songs">
        ${album.songs.map(song => {
            return `
            <li class="song">
                <div class="song__name">${song.songTitle}</div>
                ${song.links}
                ${song.duration}
                <button class="edit-song__submit">Edit</button>
                <button class="delete-song__submit">Delete</button>
                <input class="song__id" type="hidden" value="${song.songId}">
            </li>
            `
        }).join("")}
    </ul>
    <button class="view-albums">Go Back</button>`
}