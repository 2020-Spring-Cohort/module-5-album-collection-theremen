export default function ViewAlbums(artist) {
    return `
    <h3>${artist.name}</h3>
    <ul id="view-albums">
        ${artist.albums.map(album => {
            return `
            <li class="album">
                <h4 class="album__name">${album.title}</h4>
                <div>${album.image}</div>
                <div>${album.recordLabel}</div>
                <button class="edit-album__submit">Edit</button>
                <button class="delete-album__submit">Delete</button>
                <input class="album__id" type="hidden" value="${album.albumId}">
                </li>
            `
        }).join("")}
    </ul>
    <section class="add-album">
           <input class="add-album__title" type="text" placeholder="Add an Album here">
           <input class="add-album__image" type="text" placeholder="Add an Album Image here">
            <input class="add-album__recordLabel" type="text" placeholder="Add a Record Label here">
            <input class="album__artistid" type="hidden" value="${artist.artistId}">
            <button class="add-album__submit">Add an Album</button>
        </section>
    <button class="view-artists">Go Back</button>`
}